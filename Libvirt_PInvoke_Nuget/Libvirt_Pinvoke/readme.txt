Preamble:
This library is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention and adding no additional helper functions.

Libvirt Build Version: 1.2.13

Project must be either x86 or x64 build to ensure correct dll's are linked properly. ANY CPU is not a valid build configuration and a compiler error will be generated if you try to build with 'ANY CPU.'

WHEN DEBUGGING IN VISUAL STUDIO
***
	Build against .net 3.5 or lower, otherwise the debugger will think SEH exceptions are thrown and terminate the program.
	With .net 4.0, the method of handling exceptions changed and this causes debugging within visual studio using 4.0 >= to not work correctly with libvirt Mingw builds.
	Running applications build against libvirt outside of Visual studio debugger works fine and no exceptions are thrown, its only within the debugger using 4.0 >=
	Perhaps the makers of the libvirt library will make their code base buildable natively on windows. . . . .
***

API:
The reference API is here http://libvirt.org/html/. All functions and structs use the same names as are used in the API.
All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.
For example, in the libvirt-host api listing, there is a a type struct virSecurityModel, it can be referenced within your c# code as Libvirt.virSecurityModel
All Function calls are inside the Libvirt.PInvoke namespace
For example the libvirt-host api listing has a function named virTypedParamsAddDouble. This function can be called in c# via Libvirt.PInvoke.virTypedParamsAddDouble(....)