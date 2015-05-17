<h3>Preamble:</h3>
<p>This library is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention and adding no additional helper functions.</p>
<h3>Nuget Package Usage:</h3>

<p>Add Nuget package to your project.<br/>This can be done by using the package manager console and typeing 'Install-Package Libvirt_Pinvoke' or via the GUI by searching for Libvirt_PInvoke</p>
<p>Project must be either x86 or x64 build to ensure correct dll's are linked properly. ANY CPU is not a valid build configuration and a compiler error will be generated if you try to build with 'ANY CPU.'</p>

<h3>API:</h3>
<p>The reference API is here http://libvirt.org/html/. All functions and structs use the same names as are used in the API. <br/>
All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.<br/>
All Function calls are inside the Libvirt.PInvoke namespace<br/>
</p>
For example, in the libvirt-host api listing, there is a a type struct virSecurityModel, it can be referenced within your c# code as Libvirt.virSecurityModel<br/> 
Functions are in the PInvoke namespace, for example the libvirt-host api listing has a function named virTypedParamsAddDouble. This function can be called in c# via Libvirt.PInvoke.virTypedParamsAddDouble(....)

