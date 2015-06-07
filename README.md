<h3>EXAMPLES:</h3>
<p>Check out how to use this library here: https://github.com/smasherprog/VM_Manager</p>
<h3>Library Usage:</h3>
<ul>
<li>Libvirt.Pinvoke namespace: is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention, parameter, and return values; adding minimal marshaling where possible --Lowest Level, Raw C Calls!
</li>
<li>Libvirt.API namespace: is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention, parameter and return values, but adds full Marshaling and memory management features. 
</li>
<li>Libvirt.CS_Objects namespace: C# objects which utilize the lower layers for calling, but ommit unused/uneeded parameters. Host, Storage, Interface, etc. . . Use these objects as they provide the most clarity when coding.
</li>
</ul>

<h5>Libvirt CodeBase Build Version: 1.2.13</h5>
<h3>Nuget Package Installation:</h3>
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
***<p>
	When running this library in Visual studio in debugging, some functions might throw an erroneous SEH exception that will terminate the program. Just wrap in try catch and continue. When running outside of the visual studio debugger, no exceptions are thrown -- this is a visual studio debugging issue.</p>
***
<h3>API/Pinvoke Namespaces:</h3>
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


