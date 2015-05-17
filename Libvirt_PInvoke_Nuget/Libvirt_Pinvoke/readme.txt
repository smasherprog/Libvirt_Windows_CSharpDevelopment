This library includes all of the needed dll's to build a libvirt application on windows using c#.
The reference API is here http://libvirt.org/html/. All functions and structs use the same name as the API. 

All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.
All Function calls are inside the Libvirt.PInvoke namespace

For example, in the libvirt-host.h file is the following

		# define VIR_SECURITY_LABEL_BUFLEN (4096 + 1)

		typedef struct _virSecurityLabel virSecurityLabel;

		struct _virSecurityLabel {
			char label[VIR_SECURITY_LABEL_BUFLEN];    /* security label string */
			int enforcing;                            /* 1 if security policy is being enforced for domain */
		};

And the generated C# code is

		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
		public partial struct _virSecurityLabel
		{
			[MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4097)] public string @label;
			public int @enforcing;
		}


