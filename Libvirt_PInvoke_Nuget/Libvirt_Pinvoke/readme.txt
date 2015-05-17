Preamble:

This library is designed to be a 1 to 1 mapping from c# to the libvirt C API maintaining naming convention and adding no additional helper functions.

Libvirt Build Version: 1.2.15

Nuget Package Usage:

Add Nuget package to your project.
This can be done by using the package manager console and typeing 'Install-Package Libvirt_Pinvoke'
-- or --
via the GUI by searching for Libvirt_PInvoke
Project must be either x86 or x64 build to ensure correct dll's are linked properly. ANY CPU is not a valid build configuration and a compiler error will be generated if you try to build with 'ANY CPU.'
API:

The reference API is here http://libvirt.org/html/. All functions and structs use the same names as are used in the API.
All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.
For example, in the libvirt-host api listing, there is a a type struct virSecurityModel, it can be referenced within your c# code as Libvirt.virSecurityModel
All Function calls are inside the Libvirt.PInvoke namespace
For example the libvirt-host api listing has a function named virTypedParamsAddDouble. This function can be called in c# via Libvirt.PInvoke.virTypedParamsAddDouble(....)