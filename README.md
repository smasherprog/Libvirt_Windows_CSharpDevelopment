<h3>This Repo contains tools used to create a libvirt Nuget package for C#</h3>
<h3>Nuget Package Usage:</h3>

<p>Add Nuget package to your project.</p>
<p>Project must be either x86 or x64 build to ensure correct dll's are linked properly</p>

<p>The reference API is here http://libvirt.org/html/. All functions and structs use the same names as are used in the API. <br/>
All Structures, delegates, enums -- everything except function calls are in the Libvirt namespace.<br/>
All Function calls are inside the Libvirt.PInvoke namespace<br/>
</p>
For example, in the libvirt-host.h file is the following<br/>
<br/>
		# define VIR_SECURITY_LABEL_BUFLEN (4096 + 1)<br/>
<br/>
		typedef struct _virSecurityLabel virSecurityLabel;<br/>
<br/>
		struct _virSecurityLabel {<br/>
			char label[VIR_SECURITY_LABEL_BUFLEN];    /* security label string */<br/>
			int enforcing;                            /* 1 if security policy is being enforced for domain */<br/>
		};<br/>
<br/>
And the generated C# code is<br/>
<br/>
  [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet =       System.Runtime.InteropServices.CharSet.Ansi)]<br/>
		public partial struct _virSecurityLabel<br/>
		{<br/>
			[MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4097)] public string @label;<br/>
			public int @enforcing;<br/>
		}<br/>
<br/>


