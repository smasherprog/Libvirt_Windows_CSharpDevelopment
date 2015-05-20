<h3>Preamble:</h3>
<p>This library is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention and adding no additional helper functions.</p>
<h5>Libvirt Build Version: 1.2.15</h5>
<h3>Nuget Package Usage:</h3>
<ul>
<li>
  Add Nuget package to your project.
  <ul>
  <li>
  This can be done by using the package manager console and typeing 'Install-Package Libvirt_Pinvoke' 
  </li>
  <li>
    -- or --
  </li>
  <li>
    via the GUI by searching for Libvirt_PInvoke
  </li>
  </ul>
</li>
  <li>
 Project must be either x86 or x64 build to ensure correct dll's are linked properly. ANY CPU is not a valid build configuration and a compiler error will be generated if you try to build with 'ANY CPU.'
  </li>
</ul>

<h5>WHEN DEBUGGING IN VISUAL STUDIO</h5>
***
<ul>
<li>
Build against .net 3.5 or lower, otherwise the debugger will think SEH exceptions are thrown and terminate the program.
</li>
<li>With .net 4.0, the method of handling exceptions changed and this causes debugging within visual studio using 4.0 >= to not work correctly with libvirt Mingw builds.</li>
<li>Running applications build against libvirt outside of Visual studio debugger works fine and no exceptions are thrown, its only within the debugger using 4.0 >=</li>
<li>Perhaps the makers of the libvirt library will make their code base buildable natively on windows. . . . .</li>
</ul>
***
<h3>API:</h3>
<ul>
 <li>
 The reference API is here http://libvirt.org/html/. All functions and structs use the same names as are used in the API.
 </li>
  <li>
 All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.
 <ul>
 <li>
 For example, in the libvirt-host api listing, there is a a type struct virSecurityModel, it can be referenced within your c# code as Libvirt.virSecurityModel
 </li>
 </ul>
 </li>
   <li>
 All Function calls are inside the Libvirt.PInvoke namespace
 <ul>
 <li>
For example the libvirt-host api listing has a function named virTypedParamsAddDouble. This function can be called in c# via Libvirt.PInvoke.virTypedParamsAddDouble(....)
 </li>
 </ul>
</ul>
<br/> 


