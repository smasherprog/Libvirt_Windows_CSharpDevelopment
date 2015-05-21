param(
     [string]$bitness, [string]$fedoraversion, [string]$destindir
)

function Using-Object
{
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [AllowEmptyString()]
        [AllowEmptyCollection()]
        [AllowNull()]
        [Object]
        $InputObject,
 
        [Parameter(Mandatory = $true)]
        [scriptblock]
        $ScriptBlock
    )
 
    try
    {
        . $ScriptBlock
    }
    finally
    {
        if ($null -ne $InputObject -and $InputObject -is [System.IDisposable])
        {
            $InputObject.Dispose()
        }
    }
}

$ZipCommand = "C:\Program Files\7-Zip\7z.exe"
if (!(Test-Path $ZipCommand)) {
    $ZipCommand = "C:\Program Files (x86)\7-Zip\7z.exe"
    if (!(Test-Path $ZipCommand)) {
        throw "7z.exe was not found at $ZipCommand."
    }
}
set-alias zip $ZipCommand
 
function Unzip-File {
        param (
                [string] $ZipFile = $(throw "ZipFile must be specified."),
                [string] $OutputDir = $(throw "OutputDir must be specified.")
        )
         
        if (!(Test-Path($ZipFile))) {
                throw "Zip filename does not exist: $ZipFile"
                return
        }
         
        zip x -y "-o$OutputDir" $ZipFile
         
        if (!$?) {
                throw "7-zip returned an error unzipping the file."
        }
}

function CheckURLStatus{
    param([string] $url)
    Write-Host "Checking Url Status: " $url
    $HTTP_Request = [System.Net.WebRequest]::Create($url)
    Using-Object($HTTP_Response = $HTTP_Request.GetResponse()){
        [int]$HTTP_Response.StatusCode -eq 200
    }
}
function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value;
    if($Invocation.PSScriptRoot)
    {
        $Invocation.PSScriptRoot;
    }
    Elseif($Invocation.MyCommand.Path)
    {
        Split-Path $Invocation.MyCommand.Path
    }
    else
    {
        $Invocation.InvocationName.Substring(0,$Invocation.InvocationName.LastIndexOf("\"));
    }
}
function Get-FilesToLookFor{
    $filestolookfor = New-Object System.Collections.Generic.List[System.String]

    $filestolookfor.Add("mingw" +$bitness +"-curl-")
    #Search for both gcc 4 and 5 because the versoions can be different, but only one will be found so its not a big deal entering both
    $filestolookfor.Add("mingw" +$bitness +"-gcc-5")
    $filestolookfor.Add("mingw" +$bitness +"-gcc-4")
    $filestolookfor.Add("mingw" +$bitness +"-gcc-c++5")
    $filestolookfor.Add("mingw" +$bitness +"-gcc-c++4")

    $filestolookfor.Add("mingw" +$bitness +"-gettext-")
    $filestolookfor.Add("mingw" +$bitness +"-gmp-")
    $filestolookfor.Add("mingw" +$bitness +"-gnutls-")
    $filestolookfor.Add("mingw" +$bitness +"-libxml2-")
    $filestolookfor.Add("mingw" +$bitness +"-libidn-")
    $filestolookfor.Add("mingw" +$bitness +"-libtasn1")
    $filestolookfor.Add("mingw" +$bitness +"-libffi-")
    $filestolookfor.Add("mingw" +$bitness +"-libssh2-")

    $filestolookfor.Add("mingw" +$bitness +"-libvirt-1")

    
    $filestolookfor.Add("mingw" +$bitness +"-p11-kit-")
    $filestolookfor.Add("mingw" +$bitness +"-portablexdr-")
    $filestolookfor.Add("mingw" +$bitness +"-nettle-")
    $filestolookfor.Add("mingw" +$bitness +"-openssl-")

    $filestolookfor.Add("mingw" +$bitness +"-termcap-")

    $filestolookfor.Add("mingw" +$bitness +"-win-iconv-")
    $filestolookfor.Add("mingw" +$bitness +"-winpthreads-")
    $filestolookfor.Add("mingw" +$bitness +"-zlib-")
    $filestolookfor
}


#assign defaults if none given

if([string]::IsNullOrWhiteSpace($fedoraversion)) {
    $fedoraversion = "22" #default is version 22
}
if([string]::IsNullOrWhiteSpace($bitness)) {
    $bitness = "64" #default is 64 bit
} 
if($bitness -ne "32" -and $bitness -ne "64"){
    $bitness = "32" #default is 64 bit
} 

if([string]::IsNullOrWhiteSpace($destindir)) {
    $destindir = Get-ScriptDirectory #get working dir if empty
} else {
    $ValidPath = Test-Path $destindir -IsValid
    if ($ValidPath -eq $False) {
       Write-Host "Path Given is invalid, using default"
        $destindir = Get-ScriptDirectory #get working dir if empty
    }  
}
$testoutputdir = $destindir + "/libvirt"
if(Test-Path $testoutputdir){
  throw "the destination folder Libvirt cannot exist, please run this script from a directory that does not contain  libvirt/"
}
$url = "https://mirrors.fedoraproject.org/mirrorlist?repo=fedora-"+ $fedoraversion + "&arch=x86_64"
$result = Invoke-WebRequest $url

$mirrors = $result.Content.Split("`n")

foreach($line in $mirrors | where {$_ -like "http://*" } ){
    $retstatfromv = CheckURLStatus $line
    
    if($retstatfromv){
        $baseurl = $line + "Packages/m/"
        $result = Invoke-WebRequest $baseurl 
        $webclient = New-Object System.Net.WebClient
        $filestolookfor = Get-FilesToLookFor
        $libvirtversion = "1.0.0"
        foreach($atag in $result.Links){
            $possiblefilename = $atag.href
            $founditem = $false
            foreach($item in $filestolookfor){
                $founditem = $founditem -or ($possiblefilename.ToLower().StartsWith($item) -and !$possiblefilename.Contains("-static-"))
                if($founditem){
                    if($item -like "*libvirt*"){
                        $libvirtversion = $possiblefilename.Remove(0, $item.Length-1).Split('-')[0]
                    }
                    break
                }
            }
            if($founditem){
              
                Write-Host "Downloading file"$baseurl $possiblefilename
                $webclient.DownloadFile($baseurl + $possiblefilename, $possiblefilename)
                Write-Host "Unziping file " $possiblefilename " to " $destindir
                #unzip the file
                Unzip-File $possiblefilename $destindir
                [System.IO.File]::Delete($destindir+"/" + $possiblefilename)
            }
        }
        
        $filestodelete = New-Object System.Collections.Generic.List[System.String]
        foreach($file in [System.IO.Directory]::EnumerateFiles($destindir,"*.cpio")) {
            Write-Host "Unziping file " $file " to " $destindir
            Unzip-File $file $destindir
            $filestodelete.Add($file)
        }
        Write-Host "Cleaning up my mess!"
        foreach($file in $filestodelete) {
            Write-Host "Deleting " $file 
            [System.IO.File]::Delete($file)
        }
        $finalfolder = $destindir + "/libvirt"
        if($bitness -eq "64"){
            $pathtotest = $destindir + "/usr/x86_64-w64-mingw32/sys-root/mingw"
        } else {
            $pathtotest = $destindir + "/usr/i686-w64-mingw32/sys-root/mingw"
        }
 
       if (Test-Path $pathtotest) {
            [System.IO.Directory]::Move($pathtotest, $finalfolder)
        }
        
        $pathtotest = $destindir + "/usr"
        if (Test-Path $pathtotest) {
            [System.IO.Directory]::Delete($pathtotest, $true)
        }
       $pathtotest = $finalfolder + "/etc"
        if (Test-Path $pathtotest) {
            [System.IO.Directory]::Delete($pathtotest, $true)
        }
       $pathtotest = $finalfolder + "/lib"
        if (Test-Path $pathtotest) {
           [System.IO.Directory]::Delete($pathtotest, $true)
        }
       $pathtotest = $finalfolder + "/share"
        if (Test-Path $pathtotest) {
           [System.IO.Directory]::Delete($pathtotest, $true)
        }

        Write-Host "All Done, you should now have all the DLL's required for building a libvirt application on windows!"
        Write-Host "There are extra exe and other files, which can be ignored, you just need the dll's"
        Write-Host "Generating C# PInvoke files from Libvirt Headers"
 
        $args = @()
        $args += "--m PInvoke --p clang_ --namespace Libvirt"
        $args += "--output Libvirt.cs"
        $args += "--libraryPath libvirt-0.dll"
        $args += "--include $finalfolder/include/"
        $args += "--file $finalfolder/include/libvirt/libvirt.h"
        $args += "--charset Ansi"
        Write-Host "Generating .cs files"

        $CodeGenCommand = Get-ScriptDirectory
        $CodeGenCommand = $CodeGenCommand+ "/ClangSharpPInvokeGenerator.exe"
        & $CodeGenCommand $args

        $pathtotest = $finalfolder + "/bin"

        $finalcsloc= $finalfolder  + "/Libvirt.cs"
        [System.IO.File]::Move($destindir + "/Libvirt.cs", $finalcsloc)
        [System.IO.File]::Create($finalfolder + "/libvirt-" + $libvirtversion + ".txt")   
        [System.IO.Directory]::Move($pathtotest, $pathtotest + "_x"+$bitness)

        break   

    }
} 