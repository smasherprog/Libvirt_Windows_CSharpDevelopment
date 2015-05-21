namespace Libvirt
{
    using System;
    using System.Runtime.InteropServices;

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virConnect
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virStream
    {
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virSecurityLabel
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4097)] public string @label;
        public int @enforcing;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virSecurityModel
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 257)] public string @model;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 257)] public string @doi;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virTypedParameter
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 80)] public string @field;
        public int @type;
        public IntPtr @value;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNodeInfo
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)] public string @model;
        public int @memory;
        public uint @cpus;
        public uint @mhz;
        public uint @nodes;
        public uint @sockets;
        public uint @cores;
        public uint @threads;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNodeCPUStats
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 80)] public string @field;
        public ulong @value;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNodeMemoryStats
    {
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 80)] public string @field;
        public ulong @value;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virConnectCredential
    {
        public int @type;
        [MarshalAs(UnmanagedType.LPStr)] public string @prompt;
        [MarshalAs(UnmanagedType.LPStr)] public string @challenge;
        [MarshalAs(UnmanagedType.LPStr)] public string @defresult;
        [MarshalAs(UnmanagedType.LPStr)] public string @result;
        public uint @resultlen;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virConnectAuth
    {
        public IntPtr @credtype;
        public uint @ncredtype;
        public IntPtr @cb;
        public IntPtr @cbdata;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomain
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainControlInfo
    {
        public uint @state;
        public uint @details;
        public ulong @stateTime;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainInfo
    {
        public char @state;
        public int @maxMem;
        public int @memory;
        public ushort @nrVirtCpu;
        public ulong @cpuTime;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainBlockStats
    {
        public long @rd_req;
        public long @rd_bytes;
        public long @wr_req;
        public long @wr_bytes;
        public long @errs;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainInterfaceStats
    {
        public long @rx_bytes;
        public long @rx_packets;
        public long @rx_errs;
        public long @rx_drop;
        public long @tx_bytes;
        public long @tx_packets;
        public long @tx_errs;
        public long @tx_drop;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainMemoryStat
    {
        public int @tag;
        public ulong @val;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainBlockInfo
    {
        public ulong @capacity;
        public ulong @allocation;
        public ulong @physical;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virVcpuInfo
    {
        public uint @number;
        public int @state;
        public ulong @cpuTime;
        public int @cpu;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainStatsRecord
    {
        public IntPtr @dom;
        public IntPtr @params;
        public int @nparams;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainBlockJobInfo
    {
        public int @type;
        public int @bandwidth;
        public ulong @cur;
        public ulong @end;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainDiskError
    {
        [MarshalAs(UnmanagedType.LPStr)] public string @disk;
        public int @error;
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainJobInfo
    {
        public int @type;
        public ulong @timeElapsed;
        public ulong @timeRemaining;
        public ulong @dataTotal;
        public ulong @dataProcessed;
        public ulong @dataRemaining;
        public ulong @memTotal;
        public ulong @memProcessed;
        public ulong @memRemaining;
        public ulong @fileTotal;
        public ulong @fileProcessed;
        public ulong @fileRemaining;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainEventGraphicsAddress
    {
        public int @family;
        [MarshalAs(UnmanagedType.LPStr)] public string @node;
        [MarshalAs(UnmanagedType.LPStr)] public string @service;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainEventGraphicsSubjectIdentity
    {
        [MarshalAs(UnmanagedType.LPStr)] public string @type;
        [MarshalAs(UnmanagedType.LPStr)] public string @name;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainEventGraphicsSubject
    {
        public int @nidentity;
        public IntPtr @identities;
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainFSInfo
    {
        [MarshalAs(UnmanagedType.LPStr)] public string @mountpoint;
        [MarshalAs(UnmanagedType.LPStr)] public string @name;
        [MarshalAs(UnmanagedType.LPStr)] public string @fstype;
        public uint @ndevAlias;
        public IntPtr @devAlias;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virDomainSnapshot
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virInterface
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNetwork
    {
    }



    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNetworkDHCPLease
    {
        [MarshalAs(UnmanagedType.LPStr)] public string @iface;
        public long @expirytime;
        public int @type;
        [MarshalAs(UnmanagedType.LPStr)] public string @mac;
        [MarshalAs(UnmanagedType.LPStr)] public string @iaid;
        [MarshalAs(UnmanagedType.LPStr)] public string @ipaddr;
        public uint @prefix;
        [MarshalAs(UnmanagedType.LPStr)] public string @hostname;
        [MarshalAs(UnmanagedType.LPStr)] public string @clientid;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNodeDevice
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virNWFilter
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virSecret
    {
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virStoragePool
    {
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virStoragePoolInfo
    {
        public int @state;
        public ulong @capacity;
        public ulong @allocation;
        public ulong @available;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virStorageVol
    {
    }


    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct _virStorageVolInfo
    {
        public int @type;
        public ulong @capacity;
        public ulong @allocation;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virFreeCallback(IntPtr @opaque);

    public partial struct virConnectPtr
    {
        public virConnectPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virStreamPtr
    {
        public virStreamPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virSecurityLabelPtr
    {
        public virSecurityLabelPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virSecurityModelPtr
    {
        public virSecurityModelPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virTypedParameterPtr
    {
        public virTypedParameterPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virNodeInfoPtr
    {
        public virNodeInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virNodeCPUStatsPtr
    {
        public virNodeCPUStatsPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virNodeMemoryStatsPtr
    {
        public virNodeMemoryStatsPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virConnectCredentialPtr
    {
        public virConnectCredentialPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virConnectAuthCallbackPtr(IntPtr @cred, uint @ncred, IntPtr @cbdata);

    public partial struct virConnectAuthPtr
    {
        public virConnectAuthPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectCloseFunc(IntPtr @conn, int @reason, IntPtr @opaque);

    public partial struct virDomainPtr
    {
        public virDomainPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainControlInfoPtr
    {
        public virDomainControlInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainInfoPtr
    {
        public virDomainInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainBlockStatsPtr
    {
        public virDomainBlockStatsPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainInterfaceStatsPtr
    {
        public virDomainInterfaceStatsPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainMemoryStatPtr
    {
        public virDomainMemoryStatPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainBlockInfoPtr
    {
        public virDomainBlockInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virVcpuInfoPtr
    {
        public virVcpuInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainStatsRecordPtr
    {
        public virDomainStatsRecordPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainBlockJobCursor
    {
        public virDomainBlockJobCursor(ulong value)
        {
            this.Value = value;
        }

        public ulong Value;
    }

    public partial struct virDomainBlockJobInfoPtr
    {
        public virDomainBlockJobInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainDiskErrorPtr
    {
        public virDomainDiskErrorPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virConnectDomainEventCallback(IntPtr @conn, IntPtr @dom, int @event, int @detail, IntPtr @opaque);

    public partial struct virDomainJobInfoPtr
    {
        public virDomainJobInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventGenericCallback(IntPtr @conn, IntPtr @dom, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventRTCChangeCallback(IntPtr @conn, IntPtr @dom, long @utcoffset, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventWatchdogCallback(IntPtr @conn, IntPtr @dom, int @action, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventIOErrorCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @srcPath, [MarshalAs(UnmanagedType.LPStr)] string @devAlias, int @action, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventIOErrorReasonCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @srcPath, [MarshalAs(UnmanagedType.LPStr)] string @devAlias, int @action, [MarshalAs(UnmanagedType.LPStr)] string @reason, IntPtr @opaque);

    public partial struct virDomainEventGraphicsAddressPtr
    {
        public virDomainEventGraphicsAddressPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainEventGraphicsSubjectIdentityPtr
    {
        public virDomainEventGraphicsSubjectIdentityPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainEventGraphicsSubjectPtr
    {
        public virDomainEventGraphicsSubjectPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventGraphicsCallback(IntPtr @conn, IntPtr @dom, int @phase, IntPtr @local, IntPtr @remote, [MarshalAs(UnmanagedType.LPStr)] string @authScheme, IntPtr @subject, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventBlockJobCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, int @type, int @status, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventDiskChangeCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @oldSrcPath, [MarshalAs(UnmanagedType.LPStr)] string @newSrcPath, [MarshalAs(UnmanagedType.LPStr)] string @devAlias, int @reason, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventTrayChangeCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @devAlias, int @reason, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventPMWakeupCallback(IntPtr @conn, IntPtr @dom, int @reason, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventPMSuspendCallback(IntPtr @conn, IntPtr @dom, int @reason, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventBalloonChangeCallback(IntPtr @conn, IntPtr @dom, ulong @actual, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventPMSuspendDiskCallback(IntPtr @conn, IntPtr @dom, int @reason, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventDeviceRemovedCallback(IntPtr @conn, IntPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @devAlias, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventTunableCallback(IntPtr @conn, IntPtr @dom, IntPtr @params, int @nparams, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectDomainEventAgentLifecycleCallback(IntPtr @conn, IntPtr @dom, int @state, int @reason, IntPtr @opaque);

    public partial struct virDomainFSInfoPtr
    {
        public virDomainFSInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virSchedParameterPtr
    {
        public virSchedParameterPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virBlkioParameterPtr
    {
        public virBlkioParameterPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virMemoryParameterPtr
    {
        public virMemoryParameterPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virDomainSnapshotPtr
    {
        public virDomainSnapshotPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virEventHandleCallback(int @watch, int @fd, int @events, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virEventAddHandleFunc(int @fd, int @event, virEventHandleCallback @cb, IntPtr @opaque, virFreeCallback @ff);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virEventUpdateHandleFunc(int @watch, int @event);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virEventRemoveHandleFunc(int @watch);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virEventTimeoutCallback(int @timer, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virEventAddTimeoutFunc(int @timeout, virEventTimeoutCallback @cb, IntPtr @opaque, virFreeCallback @ff);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virEventUpdateTimeoutFunc(int @timer, int @timeout);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virEventRemoveTimeoutFunc(int @timer);

    public partial struct virInterfacePtr
    {
        public virInterfacePtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virNetworkPtr
    {
        public virNetworkPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectNetworkEventLifecycleCallback(IntPtr @conn, IntPtr @net, int @event, int @detail, IntPtr @opaque);

    public partial struct virNetworkDHCPLeasePtr
    {
        public virNetworkDHCPLeasePtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virConnectNetworkEventGenericCallback(IntPtr @conn, IntPtr @net, IntPtr @opaque);

    public partial struct virNodeDevicePtr
    {
        public virNodeDevicePtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virNWFilterPtr
    {
        public virNWFilterPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virSecretPtr
    {
        public virSecretPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virStoragePoolPtr
    {
        public virStoragePoolPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virStoragePoolInfoPtr
    {
        public virStoragePoolInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virStorageVolPtr
    {
        public virStorageVolPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct virStorageVolInfoPtr
    {
        public virStorageVolInfoPtr(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virStreamSourceFunc(IntPtr @st, IntPtr @data, uint @nbytes, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int virStreamSinkFunc(IntPtr @st, [MarshalAs(UnmanagedType.LPStr)] string @data, uint @nbytes, IntPtr @opaque);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void virStreamEventCallback(IntPtr @stream, int @events, IntPtr @opaque);

    public enum virNodeSuspendTarget : int
    {
        @VIR_NODE_SUSPEND_TARGET_MEM = 0,
        @VIR_NODE_SUSPEND_TARGET_DISK = 1,
        @VIR_NODE_SUSPEND_TARGET_HYBRID = 2,
    }

    public enum virTypedParameterType : int
    {
        @VIR_TYPED_PARAM_INT = 1,
        @VIR_TYPED_PARAM_UINT = 2,
        @VIR_TYPED_PARAM_LLONG = 3,
        @VIR_TYPED_PARAM_ULLONG = 4,
        @VIR_TYPED_PARAM_DOUBLE = 5,
        @VIR_TYPED_PARAM_BOOLEAN = 6,
        @VIR_TYPED_PARAM_STRING = 7,
    }

    public enum virTypedParameterFlags : int
    {
        @VIR_TYPED_PARAM_STRING_OKAY = 4,
    }

    public enum virNodeGetCPUStatsAllCPUs : int
    {
        @VIR_NODE_CPU_STATS_ALL_CPUS = -1,
    }

    public enum virNodeGetMemoryStatsAllCells : int
    {
        @VIR_NODE_MEMORY_STATS_ALL_CELLS = -1,
    }

    public enum virConnectFlags : int
    {
        @VIR_CONNECT_RO = 1,
        @VIR_CONNECT_NO_ALIASES = 2,
    }

    public enum virConnectCredentialType : int
    {
        @VIR_CRED_USERNAME = 1,
        @VIR_CRED_AUTHNAME = 2,
        @VIR_CRED_LANGUAGE = 3,
        @VIR_CRED_CNONCE = 4,
        @VIR_CRED_PASSPHRASE = 5,
        @VIR_CRED_ECHOPROMPT = 6,
        @VIR_CRED_NOECHOPROMPT = 7,
        @VIR_CRED_REALM = 8,
        @VIR_CRED_EXTERNAL = 9,
    }

    public enum virConnectCloseReason : int
    {
        @VIR_CONNECT_CLOSE_REASON_ERROR = 0,
        @VIR_CONNECT_CLOSE_REASON_EOF = 1,
        @VIR_CONNECT_CLOSE_REASON_KEEPALIVE = 2,
        @VIR_CONNECT_CLOSE_REASON_CLIENT = 3,
    }

    public enum virCPUCompareResult : int
    {
        @VIR_CPU_COMPARE_ERROR = -1,
        @VIR_CPU_COMPARE_INCOMPATIBLE = 0,
        @VIR_CPU_COMPARE_IDENTICAL = 1,
        @VIR_CPU_COMPARE_SUPERSET = 2,
    }

    public enum virConnectCompareCPUFlags : int
    {
        @VIR_CONNECT_COMPARE_CPU_FAIL_INCOMPATIBLE = 1,
    }

    public enum virConnectBaselineCPUFlags : int
    {
        @VIR_CONNECT_BASELINE_CPU_EXPAND_FEATURES = 1,
    }

    public enum virNodeAllocPagesFlags : int
    {
        @VIR_NODE_ALLOC_PAGES_ADD = 0,
        @VIR_NODE_ALLOC_PAGES_SET = 1,
    }

    public enum virDomainState : int
    {
        @VIR_DOMAIN_NOSTATE = 0,
        @VIR_DOMAIN_RUNNING = 1,
        @VIR_DOMAIN_BLOCKED = 2,
        @VIR_DOMAIN_PAUSED = 3,
        @VIR_DOMAIN_SHUTDOWN = 4,
        @VIR_DOMAIN_SHUTOFF = 5,
        @VIR_DOMAIN_CRASHED = 6,
        @VIR_DOMAIN_PMSUSPENDED = 7,
    }

    public enum virDomainNostateReason : int
    {
        @VIR_DOMAIN_NOSTATE_UNKNOWN = 0,
    }

    public enum virDomainRunningReason : int
    {
        @VIR_DOMAIN_RUNNING_UNKNOWN = 0,
        @VIR_DOMAIN_RUNNING_BOOTED = 1,
        @VIR_DOMAIN_RUNNING_MIGRATED = 2,
        @VIR_DOMAIN_RUNNING_RESTORED = 3,
        @VIR_DOMAIN_RUNNING_FROM_SNAPSHOT = 4,
        @VIR_DOMAIN_RUNNING_UNPAUSED = 5,
        @VIR_DOMAIN_RUNNING_MIGRATION_CANCELED = 6,
        @VIR_DOMAIN_RUNNING_SAVE_CANCELED = 7,
        @VIR_DOMAIN_RUNNING_WAKEUP = 8,
        @VIR_DOMAIN_RUNNING_CRASHED = 9,
    }

    public enum virDomainBlockedReason : int
    {
        @VIR_DOMAIN_BLOCKED_UNKNOWN = 0,
    }

    public enum virDomainPausedReason : int
    {
        @VIR_DOMAIN_PAUSED_UNKNOWN = 0,
        @VIR_DOMAIN_PAUSED_USER = 1,
        @VIR_DOMAIN_PAUSED_MIGRATION = 2,
        @VIR_DOMAIN_PAUSED_SAVE = 3,
        @VIR_DOMAIN_PAUSED_DUMP = 4,
        @VIR_DOMAIN_PAUSED_IOERROR = 5,
        @VIR_DOMAIN_PAUSED_WATCHDOG = 6,
        @VIR_DOMAIN_PAUSED_FROM_SNAPSHOT = 7,
        @VIR_DOMAIN_PAUSED_SHUTTING_DOWN = 8,
        @VIR_DOMAIN_PAUSED_SNAPSHOT = 9,
        @VIR_DOMAIN_PAUSED_CRASHED = 10,
    }

    public enum virDomainShutdownReason : int
    {
        @VIR_DOMAIN_SHUTDOWN_UNKNOWN = 0,
        @VIR_DOMAIN_SHUTDOWN_USER = 1,
    }

    public enum virDomainShutoffReason : int
    {
        @VIR_DOMAIN_SHUTOFF_UNKNOWN = 0,
        @VIR_DOMAIN_SHUTOFF_SHUTDOWN = 1,
        @VIR_DOMAIN_SHUTOFF_DESTROYED = 2,
        @VIR_DOMAIN_SHUTOFF_CRASHED = 3,
        @VIR_DOMAIN_SHUTOFF_MIGRATED = 4,
        @VIR_DOMAIN_SHUTOFF_SAVED = 5,
        @VIR_DOMAIN_SHUTOFF_FAILED = 6,
        @VIR_DOMAIN_SHUTOFF_FROM_SNAPSHOT = 7,
    }

    public enum virDomainCrashedReason : int
    {
        @VIR_DOMAIN_CRASHED_UNKNOWN = 0,
        @VIR_DOMAIN_CRASHED_PANICKED = 1,
    }

    public enum virDomainPMSuspendedReason : int
    {
        @VIR_DOMAIN_PMSUSPENDED_UNKNOWN = 0,
    }

    public enum virDomainPMSuspendedDiskReason : int
    {
        @VIR_DOMAIN_PMSUSPENDED_DISK_UNKNOWN = 0,
    }

    public enum virDomainControlState : int
    {
        @VIR_DOMAIN_CONTROL_OK = 0,
        @VIR_DOMAIN_CONTROL_JOB = 1,
        @VIR_DOMAIN_CONTROL_OCCUPIED = 2,
        @VIR_DOMAIN_CONTROL_ERROR = 3,
    }

    public enum virDomainModificationImpact : int
    {
        @VIR_DOMAIN_AFFECT_CURRENT = 0,
        @VIR_DOMAIN_AFFECT_LIVE = 1,
        @VIR_DOMAIN_AFFECT_CONFIG = 2,
    }

    public enum virDomainCreateFlags : int
    {
        @VIR_DOMAIN_NONE = 0,
        @VIR_DOMAIN_START_PAUSED = 1,
        @VIR_DOMAIN_START_AUTODESTROY = 2,
        @VIR_DOMAIN_START_BYPASS_CACHE = 4,
        @VIR_DOMAIN_START_FORCE_BOOT = 8,
        @VIR_DOMAIN_START_VALIDATE = 16,
    }

    public enum virDomainMemoryStatTags : int
    {
        @VIR_DOMAIN_MEMORY_STAT_SWAP_IN = 0,
        @VIR_DOMAIN_MEMORY_STAT_SWAP_OUT = 1,
        @VIR_DOMAIN_MEMORY_STAT_MAJOR_FAULT = 2,
        @VIR_DOMAIN_MEMORY_STAT_MINOR_FAULT = 3,
        @VIR_DOMAIN_MEMORY_STAT_UNUSED = 4,
        @VIR_DOMAIN_MEMORY_STAT_AVAILABLE = 5,
        @VIR_DOMAIN_MEMORY_STAT_ACTUAL_BALLOON = 6,
        @VIR_DOMAIN_MEMORY_STAT_RSS = 7,
        @VIR_DOMAIN_MEMORY_STAT_NR = 8,
    }

    public enum virDomainCoreDumpFlags : int
    {
        @VIR_DUMP_CRASH = 1,
        @VIR_DUMP_LIVE = 2,
        @VIR_DUMP_BYPASS_CACHE = 4,
        @VIR_DUMP_RESET = 8,
        @VIR_DUMP_MEMORY_ONLY = 16,
    }

    public enum virDomainCoreDumpFormat : int
    {
        @VIR_DOMAIN_CORE_DUMP_FORMAT_RAW = 0,
        @VIR_DOMAIN_CORE_DUMP_FORMAT_KDUMP_ZLIB = 1,
        @VIR_DOMAIN_CORE_DUMP_FORMAT_KDUMP_LZO = 2,
        @VIR_DOMAIN_CORE_DUMP_FORMAT_KDUMP_SNAPPY = 3,
    }

    public enum virDomainMigrateFlags : int
    {
        @VIR_MIGRATE_LIVE = 1,
        @VIR_MIGRATE_PEER2PEER = 2,
        @VIR_MIGRATE_TUNNELLED = 4,
        @VIR_MIGRATE_PERSIST_DEST = 8,
        @VIR_MIGRATE_UNDEFINE_SOURCE = 16,
        @VIR_MIGRATE_PAUSED = 32,
        @VIR_MIGRATE_NON_SHARED_DISK = 64,
        @VIR_MIGRATE_NON_SHARED_INC = 128,
        @VIR_MIGRATE_CHANGE_PROTECTION = 256,
        @VIR_MIGRATE_UNSAFE = 512,
        @VIR_MIGRATE_OFFLINE = 1024,
        @VIR_MIGRATE_COMPRESSED = 2048,
        @VIR_MIGRATE_ABORT_ON_ERROR = 4096,
        @VIR_MIGRATE_AUTO_CONVERGE = 8192,
        @VIR_MIGRATE_RDMA_PIN_ALL = 16384,
    }

    public enum virDomainShutdownFlagValues : int
    {
        @VIR_DOMAIN_SHUTDOWN_DEFAULT = 0,
        @VIR_DOMAIN_SHUTDOWN_ACPI_POWER_BTN = 1,
        @VIR_DOMAIN_SHUTDOWN_GUEST_AGENT = 2,
        @VIR_DOMAIN_SHUTDOWN_INITCTL = 4,
        @VIR_DOMAIN_SHUTDOWN_SIGNAL = 8,
        @VIR_DOMAIN_SHUTDOWN_PARAVIRT = 16,
    }

    public enum virDomainRebootFlagValues : int
    {
        @VIR_DOMAIN_REBOOT_DEFAULT = 0,
        @VIR_DOMAIN_REBOOT_ACPI_POWER_BTN = 1,
        @VIR_DOMAIN_REBOOT_GUEST_AGENT = 2,
        @VIR_DOMAIN_REBOOT_INITCTL = 4,
        @VIR_DOMAIN_REBOOT_SIGNAL = 8,
        @VIR_DOMAIN_REBOOT_PARAVIRT = 16,
    }

    public enum virDomainDestroyFlagsValues : int
    {
        @VIR_DOMAIN_DESTROY_DEFAULT = 0,
        @VIR_DOMAIN_DESTROY_GRACEFUL = 1,
    }

    public enum virDomainSaveRestoreFlags : int
    {
        @VIR_DOMAIN_SAVE_BYPASS_CACHE = 1,
        @VIR_DOMAIN_SAVE_RUNNING = 2,
        @VIR_DOMAIN_SAVE_PAUSED = 4,
    }

    public enum virDomainMemoryModFlags : int
    {
        @VIR_DOMAIN_MEM_CURRENT = 0,
        @VIR_DOMAIN_MEM_LIVE = 1,
        @VIR_DOMAIN_MEM_CONFIG = 2,
        @VIR_DOMAIN_MEM_MAXIMUM = 4,
    }

    public enum virDomainNumatuneMemMode : int
    {
        @VIR_DOMAIN_NUMATUNE_MEM_STRICT = 0,
        @VIR_DOMAIN_NUMATUNE_MEM_PREFERRED = 1,
        @VIR_DOMAIN_NUMATUNE_MEM_INTERLEAVE = 2,
    }

    public enum virDomainMetadataType : int
    {
        @VIR_DOMAIN_METADATA_DESCRIPTION = 0,
        @VIR_DOMAIN_METADATA_TITLE = 1,
        @VIR_DOMAIN_METADATA_ELEMENT = 2,
    }

    public enum virDomainXMLFlags : int
    {
        @VIR_DOMAIN_XML_SECURE = 1,
        @VIR_DOMAIN_XML_INACTIVE = 2,
        @VIR_DOMAIN_XML_UPDATE_CPU = 4,
        @VIR_DOMAIN_XML_MIGRATABLE = 8,
    }

    public enum virDomainBlockResizeFlags : int
    {
        @VIR_DOMAIN_BLOCK_RESIZE_BYTES = 1,
    }

    public enum virDomainMemoryFlags : int
    {
        @VIR_MEMORY_VIRTUAL = 1,
        @VIR_MEMORY_PHYSICAL = 2,
    }

    public enum virDomainDefineFlags : int
    {
        @VIR_DOMAIN_DEFINE_VALIDATE = 1,
    }

    public enum virDomainUndefineFlagsValues : int
    {
        @VIR_DOMAIN_UNDEFINE_MANAGED_SAVE = 1,
        @VIR_DOMAIN_UNDEFINE_SNAPSHOTS_METADATA = 2,
        @VIR_DOMAIN_UNDEFINE_NVRAM = 4,
    }

    public enum virConnectListAllDomainsFlags : int
    {
        @VIR_CONNECT_LIST_DOMAINS_ACTIVE = 1,
        @VIR_CONNECT_LIST_DOMAINS_INACTIVE = 2,
        @VIR_CONNECT_LIST_DOMAINS_PERSISTENT = 4,
        @VIR_CONNECT_LIST_DOMAINS_TRANSIENT = 8,
        @VIR_CONNECT_LIST_DOMAINS_RUNNING = 16,
        @VIR_CONNECT_LIST_DOMAINS_PAUSED = 32,
        @VIR_CONNECT_LIST_DOMAINS_SHUTOFF = 64,
        @VIR_CONNECT_LIST_DOMAINS_OTHER = 128,
        @VIR_CONNECT_LIST_DOMAINS_MANAGEDSAVE = 256,
        @VIR_CONNECT_LIST_DOMAINS_NO_MANAGEDSAVE = 512,
        @VIR_CONNECT_LIST_DOMAINS_AUTOSTART = 1024,
        @VIR_CONNECT_LIST_DOMAINS_NO_AUTOSTART = 2048,
        @VIR_CONNECT_LIST_DOMAINS_HAS_SNAPSHOT = 4096,
        @VIR_CONNECT_LIST_DOMAINS_NO_SNAPSHOT = 8192,
    }

    public enum virVcpuState : int
    {
        @VIR_VCPU_OFFLINE = 0,
        @VIR_VCPU_RUNNING = 1,
        @VIR_VCPU_BLOCKED = 2,
    }

    public enum virDomainVcpuFlags : int
    {
        @VIR_DOMAIN_VCPU_CURRENT = 0,
        @VIR_DOMAIN_VCPU_LIVE = 1,
        @VIR_DOMAIN_VCPU_CONFIG = 2,
        @VIR_DOMAIN_VCPU_MAXIMUM = 4,
        @VIR_DOMAIN_VCPU_GUEST = 8,
    }

    public enum virDomainDeviceModifyFlags : int
    {
        @VIR_DOMAIN_DEVICE_MODIFY_CURRENT = 0,
        @VIR_DOMAIN_DEVICE_MODIFY_LIVE = 1,
        @VIR_DOMAIN_DEVICE_MODIFY_CONFIG = 2,
        @VIR_DOMAIN_DEVICE_MODIFY_FORCE = 4,
    }

    public enum virDomainStatsTypes : int
    {
        @VIR_DOMAIN_STATS_STATE = 1,
        @VIR_DOMAIN_STATS_CPU_TOTAL = 2,
        @VIR_DOMAIN_STATS_BALLOON = 4,
        @VIR_DOMAIN_STATS_VCPU = 8,
        @VIR_DOMAIN_STATS_INTERFACE = 16,
        @VIR_DOMAIN_STATS_BLOCK = 32,
    }

    public enum virConnectGetAllDomainStatsFlags : int
    {
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_ACTIVE = 1,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_INACTIVE = 2,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_PERSISTENT = 4,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_TRANSIENT = 8,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_RUNNING = 16,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_PAUSED = 32,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_SHUTOFF = 64,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_OTHER = 128,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_BACKING = 1073741824,
        @VIR_CONNECT_GET_ALL_DOMAINS_STATS_ENFORCE_STATS = -2147483648,
    }

    public enum virDomainBlockJobType : int
    {
        @VIR_DOMAIN_BLOCK_JOB_TYPE_UNKNOWN = 0,
        @VIR_DOMAIN_BLOCK_JOB_TYPE_PULL = 1,
        @VIR_DOMAIN_BLOCK_JOB_TYPE_COPY = 2,
        @VIR_DOMAIN_BLOCK_JOB_TYPE_COMMIT = 3,
        @VIR_DOMAIN_BLOCK_JOB_TYPE_ACTIVE_COMMIT = 4,
    }

    public enum virDomainBlockJobAbortFlags : int
    {
        @VIR_DOMAIN_BLOCK_JOB_ABORT_ASYNC = 1,
        @VIR_DOMAIN_BLOCK_JOB_ABORT_PIVOT = 2,
    }

    public enum virDomainBlockJobInfoFlags : int
    {
        @VIR_DOMAIN_BLOCK_JOB_INFO_BANDWIDTH_BYTES = 1,
    }

    public enum virDomainBlockJobSetSpeedFlags : int
    {
        @VIR_DOMAIN_BLOCK_JOB_SPEED_BANDWIDTH_BYTES = 1,
    }

    public enum virDomainBlockPullFlags : int
    {
        @VIR_DOMAIN_BLOCK_PULL_BANDWIDTH_BYTES = 64,
    }

    public enum virDomainBlockRebaseFlags : int
    {
        @VIR_DOMAIN_BLOCK_REBASE_SHALLOW = 1,
        @VIR_DOMAIN_BLOCK_REBASE_REUSE_EXT = 2,
        @VIR_DOMAIN_BLOCK_REBASE_COPY_RAW = 4,
        @VIR_DOMAIN_BLOCK_REBASE_COPY = 8,
        @VIR_DOMAIN_BLOCK_REBASE_RELATIVE = 16,
        @VIR_DOMAIN_BLOCK_REBASE_COPY_DEV = 32,
        @VIR_DOMAIN_BLOCK_REBASE_BANDWIDTH_BYTES = 64,
    }

    public enum virDomainBlockCopyFlags : int
    {
        @VIR_DOMAIN_BLOCK_COPY_SHALLOW = 1,
        @VIR_DOMAIN_BLOCK_COPY_REUSE_EXT = 2,
    }

    public enum virDomainBlockCommitFlags : int
    {
        @VIR_DOMAIN_BLOCK_COMMIT_SHALLOW = 1,
        @VIR_DOMAIN_BLOCK_COMMIT_DELETE = 2,
        @VIR_DOMAIN_BLOCK_COMMIT_ACTIVE = 4,
        @VIR_DOMAIN_BLOCK_COMMIT_RELATIVE = 8,
        @VIR_DOMAIN_BLOCK_COMMIT_BANDWIDTH_BYTES = 16,
    }

    public enum virDomainDiskErrorCode : int
    {
        @VIR_DOMAIN_DISK_ERROR_NONE = 0,
        @VIR_DOMAIN_DISK_ERROR_UNSPEC = 1,
        @VIR_DOMAIN_DISK_ERROR_NO_SPACE = 2,
    }

    public enum virKeycodeSet : int
    {
        @VIR_KEYCODE_SET_LINUX = 0,
        @VIR_KEYCODE_SET_XT = 1,
        @VIR_KEYCODE_SET_ATSET1 = 2,
        @VIR_KEYCODE_SET_ATSET2 = 3,
        @VIR_KEYCODE_SET_ATSET3 = 4,
        @VIR_KEYCODE_SET_OSX = 5,
        @VIR_KEYCODE_SET_XT_KBD = 6,
        @VIR_KEYCODE_SET_USB = 7,
        @VIR_KEYCODE_SET_WIN32 = 8,
        @VIR_KEYCODE_SET_RFB = 9,
    }

    public enum virDomainProcessSignal : int
    {
        @VIR_DOMAIN_PROCESS_SIGNAL_NOP = 0,
        @VIR_DOMAIN_PROCESS_SIGNAL_HUP = 1,
        @VIR_DOMAIN_PROCESS_SIGNAL_INT = 2,
        @VIR_DOMAIN_PROCESS_SIGNAL_QUIT = 3,
        @VIR_DOMAIN_PROCESS_SIGNAL_ILL = 4,
        @VIR_DOMAIN_PROCESS_SIGNAL_TRAP = 5,
        @VIR_DOMAIN_PROCESS_SIGNAL_ABRT = 6,
        @VIR_DOMAIN_PROCESS_SIGNAL_BUS = 7,
        @VIR_DOMAIN_PROCESS_SIGNAL_FPE = 8,
        @VIR_DOMAIN_PROCESS_SIGNAL_KILL = 9,
        @VIR_DOMAIN_PROCESS_SIGNAL_USR1 = 10,
        @VIR_DOMAIN_PROCESS_SIGNAL_SEGV = 11,
        @VIR_DOMAIN_PROCESS_SIGNAL_USR2 = 12,
        @VIR_DOMAIN_PROCESS_SIGNAL_PIPE = 13,
        @VIR_DOMAIN_PROCESS_SIGNAL_ALRM = 14,
        @VIR_DOMAIN_PROCESS_SIGNAL_TERM = 15,
        @VIR_DOMAIN_PROCESS_SIGNAL_STKFLT = 16,
        @VIR_DOMAIN_PROCESS_SIGNAL_CHLD = 17,
        @VIR_DOMAIN_PROCESS_SIGNAL_CONT = 18,
        @VIR_DOMAIN_PROCESS_SIGNAL_STOP = 19,
        @VIR_DOMAIN_PROCESS_SIGNAL_TSTP = 20,
        @VIR_DOMAIN_PROCESS_SIGNAL_TTIN = 21,
        @VIR_DOMAIN_PROCESS_SIGNAL_TTOU = 22,
        @VIR_DOMAIN_PROCESS_SIGNAL_URG = 23,
        @VIR_DOMAIN_PROCESS_SIGNAL_XCPU = 24,
        @VIR_DOMAIN_PROCESS_SIGNAL_XFSZ = 25,
        @VIR_DOMAIN_PROCESS_SIGNAL_VTALRM = 26,
        @VIR_DOMAIN_PROCESS_SIGNAL_PROF = 27,
        @VIR_DOMAIN_PROCESS_SIGNAL_WINCH = 28,
        @VIR_DOMAIN_PROCESS_SIGNAL_POLL = 29,
        @VIR_DOMAIN_PROCESS_SIGNAL_PWR = 30,
        @VIR_DOMAIN_PROCESS_SIGNAL_SYS = 31,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT0 = 32,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT1 = 33,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT2 = 34,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT3 = 35,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT4 = 36,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT5 = 37,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT6 = 38,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT7 = 39,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT8 = 40,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT9 = 41,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT10 = 42,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT11 = 43,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT12 = 44,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT13 = 45,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT14 = 46,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT15 = 47,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT16 = 48,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT17 = 49,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT18 = 50,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT19 = 51,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT20 = 52,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT21 = 53,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT22 = 54,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT23 = 55,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT24 = 56,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT25 = 57,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT26 = 58,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT27 = 59,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT28 = 60,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT29 = 61,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT30 = 62,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT31 = 63,
        @VIR_DOMAIN_PROCESS_SIGNAL_RT32 = 64,
    }

    public enum virDomainEventType : int
    {
        @VIR_DOMAIN_EVENT_DEFINED = 0,
        @VIR_DOMAIN_EVENT_UNDEFINED = 1,
        @VIR_DOMAIN_EVENT_STARTED = 2,
        @VIR_DOMAIN_EVENT_SUSPENDED = 3,
        @VIR_DOMAIN_EVENT_RESUMED = 4,
        @VIR_DOMAIN_EVENT_STOPPED = 5,
        @VIR_DOMAIN_EVENT_SHUTDOWN = 6,
        @VIR_DOMAIN_EVENT_PMSUSPENDED = 7,
        @VIR_DOMAIN_EVENT_CRASHED = 8,
    }

    public enum virDomainEventDefinedDetailType : int
    {
        @VIR_DOMAIN_EVENT_DEFINED_ADDED = 0,
        @VIR_DOMAIN_EVENT_DEFINED_UPDATED = 1,
    }

    public enum virDomainEventUndefinedDetailType : int
    {
        @VIR_DOMAIN_EVENT_UNDEFINED_REMOVED = 0,
    }

    public enum virDomainEventStartedDetailType : int
    {
        @VIR_DOMAIN_EVENT_STARTED_BOOTED = 0,
        @VIR_DOMAIN_EVENT_STARTED_MIGRATED = 1,
        @VIR_DOMAIN_EVENT_STARTED_RESTORED = 2,
        @VIR_DOMAIN_EVENT_STARTED_FROM_SNAPSHOT = 3,
        @VIR_DOMAIN_EVENT_STARTED_WAKEUP = 4,
    }

    public enum virDomainEventSuspendedDetailType : int
    {
        @VIR_DOMAIN_EVENT_SUSPENDED_PAUSED = 0,
        @VIR_DOMAIN_EVENT_SUSPENDED_MIGRATED = 1,
        @VIR_DOMAIN_EVENT_SUSPENDED_IOERROR = 2,
        @VIR_DOMAIN_EVENT_SUSPENDED_WATCHDOG = 3,
        @VIR_DOMAIN_EVENT_SUSPENDED_RESTORED = 4,
        @VIR_DOMAIN_EVENT_SUSPENDED_FROM_SNAPSHOT = 5,
        @VIR_DOMAIN_EVENT_SUSPENDED_API_ERROR = 6,
    }

    public enum virDomainEventResumedDetailType : int
    {
        @VIR_DOMAIN_EVENT_RESUMED_UNPAUSED = 0,
        @VIR_DOMAIN_EVENT_RESUMED_MIGRATED = 1,
        @VIR_DOMAIN_EVENT_RESUMED_FROM_SNAPSHOT = 2,
    }

    public enum virDomainEventStoppedDetailType : int
    {
        @VIR_DOMAIN_EVENT_STOPPED_SHUTDOWN = 0,
        @VIR_DOMAIN_EVENT_STOPPED_DESTROYED = 1,
        @VIR_DOMAIN_EVENT_STOPPED_CRASHED = 2,
        @VIR_DOMAIN_EVENT_STOPPED_MIGRATED = 3,
        @VIR_DOMAIN_EVENT_STOPPED_SAVED = 4,
        @VIR_DOMAIN_EVENT_STOPPED_FAILED = 5,
        @VIR_DOMAIN_EVENT_STOPPED_FROM_SNAPSHOT = 6,
    }

    public enum virDomainEventShutdownDetailType : int
    {
        @VIR_DOMAIN_EVENT_SHUTDOWN_FINISHED = 0,
    }

    public enum virDomainEventPMSuspendedDetailType : int
    {
        @VIR_DOMAIN_EVENT_PMSUSPENDED_MEMORY = 0,
        @VIR_DOMAIN_EVENT_PMSUSPENDED_DISK = 1,
    }

    public enum virDomainEventCrashedDetailType : int
    {
        @VIR_DOMAIN_EVENT_CRASHED_PANICKED = 0,
    }

    public enum virDomainJobType : int
    {
        @VIR_DOMAIN_JOB_NONE = 0,
        @VIR_DOMAIN_JOB_BOUNDED = 1,
        @VIR_DOMAIN_JOB_UNBOUNDED = 2,
        @VIR_DOMAIN_JOB_COMPLETED = 3,
        @VIR_DOMAIN_JOB_FAILED = 4,
        @VIR_DOMAIN_JOB_CANCELLED = 5,
    }

    public enum virDomainGetJobStatsFlags : int
    {
        @VIR_DOMAIN_JOB_STATS_COMPLETED = 1,
    }

    public enum virDomainEventWatchdogAction : int
    {
        @VIR_DOMAIN_EVENT_WATCHDOG_NONE = 0,
        @VIR_DOMAIN_EVENT_WATCHDOG_PAUSE = 1,
        @VIR_DOMAIN_EVENT_WATCHDOG_RESET = 2,
        @VIR_DOMAIN_EVENT_WATCHDOG_POWEROFF = 3,
        @VIR_DOMAIN_EVENT_WATCHDOG_SHUTDOWN = 4,
        @VIR_DOMAIN_EVENT_WATCHDOG_DEBUG = 5,
    }

    public enum virDomainEventIOErrorAction : int
    {
        @VIR_DOMAIN_EVENT_IO_ERROR_NONE = 0,
        @VIR_DOMAIN_EVENT_IO_ERROR_PAUSE = 1,
        @VIR_DOMAIN_EVENT_IO_ERROR_REPORT = 2,
    }

    public enum virDomainEventGraphicsPhase : int
    {
        @VIR_DOMAIN_EVENT_GRAPHICS_CONNECT = 0,
        @VIR_DOMAIN_EVENT_GRAPHICS_INITIALIZE = 1,
        @VIR_DOMAIN_EVENT_GRAPHICS_DISCONNECT = 2,
    }

    public enum virDomainEventGraphicsAddressType : int
    {
        @VIR_DOMAIN_EVENT_GRAPHICS_ADDRESS_IPV4 = 0,
        @VIR_DOMAIN_EVENT_GRAPHICS_ADDRESS_IPV6 = 1,
        @VIR_DOMAIN_EVENT_GRAPHICS_ADDRESS_UNIX = 2,
    }

    public enum virConnectDomainEventBlockJobStatus : int
    {
        @VIR_DOMAIN_BLOCK_JOB_COMPLETED = 0,
        @VIR_DOMAIN_BLOCK_JOB_FAILED = 1,
        @VIR_DOMAIN_BLOCK_JOB_CANCELED = 2,
        @VIR_DOMAIN_BLOCK_JOB_READY = 3,
    }

    public enum virConnectDomainEventDiskChangeReason : int
    {
        @VIR_DOMAIN_EVENT_DISK_CHANGE_MISSING_ON_START = 0,
        @VIR_DOMAIN_EVENT_DISK_DROP_MISSING_ON_START = 1,
    }

    public enum virDomainEventTrayChangeReason : int
    {
        @VIR_DOMAIN_EVENT_TRAY_CHANGE_OPEN = 0,
        @VIR_DOMAIN_EVENT_TRAY_CHANGE_CLOSE = 1,
    }

    public enum virConnectDomainEventAgentLifecycleState : int
    {
        @VIR_CONNECT_DOMAIN_EVENT_AGENT_LIFECYCLE_STATE_CONNECTED = 1,
        @VIR_CONNECT_DOMAIN_EVENT_AGENT_LIFECYCLE_STATE_DISCONNECTED = 2,
    }

    public enum virConnectDomainEventAgentLifecycleReason : int
    {
        @VIR_CONNECT_DOMAIN_EVENT_AGENT_LIFECYCLE_REASON_UNKNOWN = 0,
        @VIR_CONNECT_DOMAIN_EVENT_AGENT_LIFECYCLE_REASON_DOMAIN_STARTED = 1,
        @VIR_CONNECT_DOMAIN_EVENT_AGENT_LIFECYCLE_REASON_CHANNEL = 2,
    }

    public enum virDomainEventID : int
    {
        @VIR_DOMAIN_EVENT_ID_LIFECYCLE = 0,
        @VIR_DOMAIN_EVENT_ID_REBOOT = 1,
        @VIR_DOMAIN_EVENT_ID_RTC_CHANGE = 2,
        @VIR_DOMAIN_EVENT_ID_WATCHDOG = 3,
        @VIR_DOMAIN_EVENT_ID_IO_ERROR = 4,
        @VIR_DOMAIN_EVENT_ID_GRAPHICS = 5,
        @VIR_DOMAIN_EVENT_ID_IO_ERROR_REASON = 6,
        @VIR_DOMAIN_EVENT_ID_CONTROL_ERROR = 7,
        @VIR_DOMAIN_EVENT_ID_BLOCK_JOB = 8,
        @VIR_DOMAIN_EVENT_ID_DISK_CHANGE = 9,
        @VIR_DOMAIN_EVENT_ID_TRAY_CHANGE = 10,
        @VIR_DOMAIN_EVENT_ID_PMWAKEUP = 11,
        @VIR_DOMAIN_EVENT_ID_PMSUSPEND = 12,
        @VIR_DOMAIN_EVENT_ID_BALLOON_CHANGE = 13,
        @VIR_DOMAIN_EVENT_ID_PMSUSPEND_DISK = 14,
        @VIR_DOMAIN_EVENT_ID_DEVICE_REMOVED = 15,
        @VIR_DOMAIN_EVENT_ID_BLOCK_JOB_2 = 16,
        @VIR_DOMAIN_EVENT_ID_TUNABLE = 17,
        @VIR_DOMAIN_EVENT_ID_AGENT_LIFECYCLE = 18,
    }

    public enum virDomainConsoleFlags : int
    {
        @VIR_DOMAIN_CONSOLE_FORCE = 1,
        @VIR_DOMAIN_CONSOLE_SAFE = 2,
    }

    public enum virDomainChannelFlags : int
    {
        @VIR_DOMAIN_CHANNEL_FORCE = 1,
    }

    public enum virDomainOpenGraphicsFlags : int
    {
        @VIR_DOMAIN_OPEN_GRAPHICS_SKIPAUTH = 1,
    }

    public enum virDomainSetTimeFlags : int
    {
        @VIR_DOMAIN_TIME_SYNC = 1,
    }

    public enum virSchedParameterType : int
    {
        @VIR_DOMAIN_SCHED_FIELD_INT = 1,
        @VIR_DOMAIN_SCHED_FIELD_UINT = 2,
        @VIR_DOMAIN_SCHED_FIELD_LLONG = 3,
        @VIR_DOMAIN_SCHED_FIELD_ULLONG = 4,
        @VIR_DOMAIN_SCHED_FIELD_DOUBLE = 5,
        @VIR_DOMAIN_SCHED_FIELD_BOOLEAN = 6,
    }

    public enum virBlkioParameterType : int
    {
        @VIR_DOMAIN_BLKIO_PARAM_INT = 1,
        @VIR_DOMAIN_BLKIO_PARAM_UINT = 2,
        @VIR_DOMAIN_BLKIO_PARAM_LLONG = 3,
        @VIR_DOMAIN_BLKIO_PARAM_ULLONG = 4,
        @VIR_DOMAIN_BLKIO_PARAM_DOUBLE = 5,
        @VIR_DOMAIN_BLKIO_PARAM_BOOLEAN = 6,
    }

    public enum virMemoryParameterType : int
    {
        @VIR_DOMAIN_MEMORY_PARAM_INT = 1,
        @VIR_DOMAIN_MEMORY_PARAM_UINT = 2,
        @VIR_DOMAIN_MEMORY_PARAM_LLONG = 3,
        @VIR_DOMAIN_MEMORY_PARAM_ULLONG = 4,
        @VIR_DOMAIN_MEMORY_PARAM_DOUBLE = 5,
        @VIR_DOMAIN_MEMORY_PARAM_BOOLEAN = 6,
    }

    public enum virDomainSnapshotCreateFlags : int
    {
        @VIR_DOMAIN_SNAPSHOT_CREATE_REDEFINE = 1,
        @VIR_DOMAIN_SNAPSHOT_CREATE_CURRENT = 2,
        @VIR_DOMAIN_SNAPSHOT_CREATE_NO_METADATA = 4,
        @VIR_DOMAIN_SNAPSHOT_CREATE_HALT = 8,
        @VIR_DOMAIN_SNAPSHOT_CREATE_DISK_ONLY = 16,
        @VIR_DOMAIN_SNAPSHOT_CREATE_REUSE_EXT = 32,
        @VIR_DOMAIN_SNAPSHOT_CREATE_QUIESCE = 64,
        @VIR_DOMAIN_SNAPSHOT_CREATE_ATOMIC = 128,
        @VIR_DOMAIN_SNAPSHOT_CREATE_LIVE = 256,
    }

    public enum virDomainSnapshotListFlags : int
    {
        @VIR_DOMAIN_SNAPSHOT_LIST_ROOTS = 1,
        @VIR_DOMAIN_SNAPSHOT_LIST_DESCENDANTS = 1,
        @VIR_DOMAIN_SNAPSHOT_LIST_LEAVES = 4,
        @VIR_DOMAIN_SNAPSHOT_LIST_NO_LEAVES = 8,
        @VIR_DOMAIN_SNAPSHOT_LIST_METADATA = 2,
        @VIR_DOMAIN_SNAPSHOT_LIST_NO_METADATA = 16,
        @VIR_DOMAIN_SNAPSHOT_LIST_INACTIVE = 32,
        @VIR_DOMAIN_SNAPSHOT_LIST_ACTIVE = 64,
        @VIR_DOMAIN_SNAPSHOT_LIST_DISK_ONLY = 128,
        @VIR_DOMAIN_SNAPSHOT_LIST_INTERNAL = 256,
        @VIR_DOMAIN_SNAPSHOT_LIST_EXTERNAL = 512,
    }

    public enum virDomainSnapshotRevertFlags : int
    {
        @VIR_DOMAIN_SNAPSHOT_REVERT_RUNNING = 1,
        @VIR_DOMAIN_SNAPSHOT_REVERT_PAUSED = 2,
        @VIR_DOMAIN_SNAPSHOT_REVERT_FORCE = 4,
    }

    public enum virDomainSnapshotDeleteFlags : int
    {
        @VIR_DOMAIN_SNAPSHOT_DELETE_CHILDREN = 1,
        @VIR_DOMAIN_SNAPSHOT_DELETE_METADATA_ONLY = 2,
        @VIR_DOMAIN_SNAPSHOT_DELETE_CHILDREN_ONLY = 4,
    }

    public enum virEventHandleType : int
    {
        @VIR_EVENT_HANDLE_READABLE = 1,
        @VIR_EVENT_HANDLE_WRITABLE = 2,
        @VIR_EVENT_HANDLE_ERROR = 4,
        @VIR_EVENT_HANDLE_HANGUP = 8,
    }

    public enum virConnectListAllInterfacesFlags : int
    {
        @VIR_CONNECT_LIST_INTERFACES_INACTIVE = 1,
        @VIR_CONNECT_LIST_INTERFACES_ACTIVE = 2,
    }

    public enum virInterfaceXMLFlags : int
    {
        @VIR_INTERFACE_XML_INACTIVE = 1,
    }

    public enum virNetworkXMLFlags : int
    {
        @VIR_NETWORK_XML_INACTIVE = 1,
    }

    public enum virConnectListAllNetworksFlags : int
    {
        @VIR_CONNECT_LIST_NETWORKS_INACTIVE = 1,
        @VIR_CONNECT_LIST_NETWORKS_ACTIVE = 2,
        @VIR_CONNECT_LIST_NETWORKS_PERSISTENT = 4,
        @VIR_CONNECT_LIST_NETWORKS_TRANSIENT = 8,
        @VIR_CONNECT_LIST_NETWORKS_AUTOSTART = 16,
        @VIR_CONNECT_LIST_NETWORKS_NO_AUTOSTART = 32,
    }

    public enum virNetworkUpdateCommand : int
    {
        @VIR_NETWORK_UPDATE_COMMAND_NONE = 0,
        @VIR_NETWORK_UPDATE_COMMAND_MODIFY = 1,
        @VIR_NETWORK_UPDATE_COMMAND_DELETE = 2,
        @VIR_NETWORK_UPDATE_COMMAND_ADD_LAST = 3,
        @VIR_NETWORK_UPDATE_COMMAND_ADD_FIRST = 4,
    }

    public enum virNetworkUpdateSection : int
    {
        @VIR_NETWORK_SECTION_NONE = 0,
        @VIR_NETWORK_SECTION_BRIDGE = 1,
        @VIR_NETWORK_SECTION_DOMAIN = 2,
        @VIR_NETWORK_SECTION_IP = 3,
        @VIR_NETWORK_SECTION_IP_DHCP_HOST = 4,
        @VIR_NETWORK_SECTION_IP_DHCP_RANGE = 5,
        @VIR_NETWORK_SECTION_FORWARD = 6,
        @VIR_NETWORK_SECTION_FORWARD_INTERFACE = 7,
        @VIR_NETWORK_SECTION_FORWARD_PF = 8,
        @VIR_NETWORK_SECTION_PORTGROUP = 9,
        @VIR_NETWORK_SECTION_DNS_HOST = 10,
        @VIR_NETWORK_SECTION_DNS_TXT = 11,
        @VIR_NETWORK_SECTION_DNS_SRV = 12,
    }

    public enum virNetworkUpdateFlags : int
    {
        @VIR_NETWORK_UPDATE_AFFECT_CURRENT = 0,
        @VIR_NETWORK_UPDATE_AFFECT_LIVE = 1,
        @VIR_NETWORK_UPDATE_AFFECT_CONFIG = 2,
    }

    public enum virNetworkEventLifecycleType : int
    {
        @VIR_NETWORK_EVENT_DEFINED = 0,
        @VIR_NETWORK_EVENT_UNDEFINED = 1,
        @VIR_NETWORK_EVENT_STARTED = 2,
        @VIR_NETWORK_EVENT_STOPPED = 3,
    }

    public enum virNetworkEventID : int
    {
        @VIR_NETWORK_EVENT_ID_LIFECYCLE = 0,
    }

    public enum virIPAddrType : int
    {
        @VIR_IP_ADDR_TYPE_IPV4 = 0,
        @VIR_IP_ADDR_TYPE_IPV6 = 1,
    }

    public enum virConnectListAllNodeDeviceFlags : int
    {
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_SYSTEM = 1,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_PCI_DEV = 2,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_USB_DEV = 4,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_USB_INTERFACE = 8,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_NET = 16,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_SCSI_HOST = 32,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_SCSI_TARGET = 64,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_SCSI = 128,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_STORAGE = 256,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_FC_HOST = 512,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_VPORTS = 1024,
        @VIR_CONNECT_LIST_NODE_DEVICES_CAP_SCSI_GENERIC = 2048,
    }

    public enum virSecretUsageType : int
    {
        @VIR_SECRET_USAGE_TYPE_NONE = 0,
        @VIR_SECRET_USAGE_TYPE_VOLUME = 1,
        @VIR_SECRET_USAGE_TYPE_CEPH = 2,
        @VIR_SECRET_USAGE_TYPE_ISCSI = 3,
    }

    public enum virConnectListAllSecretsFlags : int
    {
        @VIR_CONNECT_LIST_SECRETS_EPHEMERAL = 1,
        @VIR_CONNECT_LIST_SECRETS_NO_EPHEMERAL = 2,
        @VIR_CONNECT_LIST_SECRETS_PRIVATE = 4,
        @VIR_CONNECT_LIST_SECRETS_NO_PRIVATE = 8,
    }

    public enum virStoragePoolState : int
    {
        @VIR_STORAGE_POOL_INACTIVE = 0,
        @VIR_STORAGE_POOL_BUILDING = 1,
        @VIR_STORAGE_POOL_RUNNING = 2,
        @VIR_STORAGE_POOL_DEGRADED = 3,
        @VIR_STORAGE_POOL_INACCESSIBLE = 4,
    }

    public enum virStoragePoolBuildFlags : int
    {
        @VIR_STORAGE_POOL_BUILD_NEW = 0,
        @VIR_STORAGE_POOL_BUILD_REPAIR = 1,
        @VIR_STORAGE_POOL_BUILD_RESIZE = 2,
        @VIR_STORAGE_POOL_BUILD_NO_OVERWRITE = 4,
        @VIR_STORAGE_POOL_BUILD_OVERWRITE = 8,
    }

    public enum virStoragePoolDeleteFlags : int
    {
        @VIR_STORAGE_POOL_DELETE_NORMAL = 0,
        @VIR_STORAGE_POOL_DELETE_ZEROED = 1,
    }

    public enum virStorageVolType : int
    {
        @VIR_STORAGE_VOL_FILE = 0,
        @VIR_STORAGE_VOL_BLOCK = 1,
        @VIR_STORAGE_VOL_DIR = 2,
        @VIR_STORAGE_VOL_NETWORK = 3,
        @VIR_STORAGE_VOL_NETDIR = 4,
    }

    public enum virStorageVolDeleteFlags : int
    {
        @VIR_STORAGE_VOL_DELETE_NORMAL = 0,
        @VIR_STORAGE_VOL_DELETE_ZEROED = 1,
    }

    public enum virStorageVolWipeAlgorithm : int
    {
        @VIR_STORAGE_VOL_WIPE_ALG_ZERO = 0,
        @VIR_STORAGE_VOL_WIPE_ALG_NNSA = 1,
        @VIR_STORAGE_VOL_WIPE_ALG_DOD = 2,
        @VIR_STORAGE_VOL_WIPE_ALG_BSI = 3,
        @VIR_STORAGE_VOL_WIPE_ALG_GUTMANN = 4,
        @VIR_STORAGE_VOL_WIPE_ALG_SCHNEIER = 5,
        @VIR_STORAGE_VOL_WIPE_ALG_PFITZNER7 = 6,
        @VIR_STORAGE_VOL_WIPE_ALG_PFITZNER33 = 7,
        @VIR_STORAGE_VOL_WIPE_ALG_RANDOM = 8,
    }

    public enum virStorageXMLFlags : int
    {
        @VIR_STORAGE_XML_INACTIVE = 1,
    }

    public enum virConnectListAllStoragePoolsFlags : int
    {
        @VIR_CONNECT_LIST_STORAGE_POOLS_INACTIVE = 1,
        @VIR_CONNECT_LIST_STORAGE_POOLS_ACTIVE = 2,
        @VIR_CONNECT_LIST_STORAGE_POOLS_PERSISTENT = 4,
        @VIR_CONNECT_LIST_STORAGE_POOLS_TRANSIENT = 8,
        @VIR_CONNECT_LIST_STORAGE_POOLS_AUTOSTART = 16,
        @VIR_CONNECT_LIST_STORAGE_POOLS_NO_AUTOSTART = 32,
        @VIR_CONNECT_LIST_STORAGE_POOLS_DIR = 64,
        @VIR_CONNECT_LIST_STORAGE_POOLS_FS = 128,
        @VIR_CONNECT_LIST_STORAGE_POOLS_NETFS = 256,
        @VIR_CONNECT_LIST_STORAGE_POOLS_LOGICAL = 512,
        @VIR_CONNECT_LIST_STORAGE_POOLS_DISK = 1024,
        @VIR_CONNECT_LIST_STORAGE_POOLS_ISCSI = 2048,
        @VIR_CONNECT_LIST_STORAGE_POOLS_SCSI = 4096,
        @VIR_CONNECT_LIST_STORAGE_POOLS_MPATH = 8192,
        @VIR_CONNECT_LIST_STORAGE_POOLS_RBD = 16384,
        @VIR_CONNECT_LIST_STORAGE_POOLS_SHEEPDOG = 32768,
        @VIR_CONNECT_LIST_STORAGE_POOLS_GLUSTER = 65536,
        @VIR_CONNECT_LIST_STORAGE_POOLS_ZFS = 131072,
    }

    public enum virStorageVolCreateFlags : int
    {
        @VIR_STORAGE_VOL_CREATE_PREALLOC_METADATA = 1,
        @VIR_STORAGE_VOL_CREATE_REFLINK = 2,
    }

    public enum virStorageVolResizeFlags : int
    {
        @VIR_STORAGE_VOL_RESIZE_ALLOCATE = 1,
        @VIR_STORAGE_VOL_RESIZE_DELTA = 2,
        @VIR_STORAGE_VOL_RESIZE_SHRINK = 4,
    }

    public enum virStreamFlags : int
    {
        @VIR_STREAM_NONBLOCK = 1,
    }

    public enum virStreamEventType : int
    {
        @VIR_STREAM_EVENT_READABLE = 1,
        @VIR_STREAM_EVENT_WRITABLE = 2,
        @VIR_STREAM_EVENT_ERROR = 4,
        @VIR_STREAM_EVENT_HANGUP = 8,
    }

    public static class PInvoke
    {
        private const string libraryPath = "libvirt-0.dll";

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGet", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virTypedParameterPtr virTypedParamsGet(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetInt", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetInt(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetUInt", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetUInt(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetLLong", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetLLong(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetULLong", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetULLong(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetDouble", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetDouble(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetBoolean", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetBoolean(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsGetString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsGetString(virTypedParameterPtr @params, int @nparams, [MarshalAs(UnmanagedType.LPStr)] string @name, out IntPtr @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddInt", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddInt(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, int @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddUInt", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddUInt(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, uint @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddLLong", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddLLong(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, long @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddULLong", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddULLong(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, ulong @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddDouble", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddDouble(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, double @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddBoolean", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddBoolean(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, int @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddString(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsAddFromString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virTypedParamsAddFromString(IntPtr @params, IntPtr @nparams, IntPtr @maxparams, [MarshalAs(UnmanagedType.LPStr)] string @name, int @type, [MarshalAs(UnmanagedType.LPStr)] string @value);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsClear", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virTypedParamsClear(virTypedParameterPtr @params, int @nparams);

        [DllImport(libraryPath, EntryPoint = "virTypedParamsFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virTypedParamsFree(virTypedParameterPtr @params, int @nparams);

        [DllImport(libraryPath, EntryPoint = "virNodeGetMemoryParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetMemoryParameters(virConnectPtr @conn, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeSetMemoryParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeSetMemoryParameters(virConnectPtr @conn, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeGetCPUMap", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetCPUMap(virConnectPtr @conn, out IntPtr @cpumap, IntPtr @online, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virGetVersion", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virGetVersion(IntPtr @libVer, [MarshalAs(UnmanagedType.LPStr)] string @type, IntPtr @typeVer);

        [DllImport(libraryPath, EntryPoint = "virInitialize", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInitialize();

        [DllImport(libraryPath, EntryPoint = "virConnectOpen", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virConnectOpen([MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virConnectOpenReadOnly", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virConnectOpenReadOnly([MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virConnectOpenAuth", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virConnectOpenAuth([MarshalAs(UnmanagedType.LPStr)] string @name, virConnectAuthPtr @auth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectRef(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectClose", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectClose(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectGetType", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virConnectGetType(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectGetVersion", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectGetVersion(virConnectPtr @conn, IntPtr @hvVer);

        [DllImport(libraryPath, EntryPoint = "virConnectGetLibVersion", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectGetLibVersion(virConnectPtr @conn, IntPtr @libVer);

        [DllImport(libraryPath, EntryPoint = "virConnectGetHostname", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectGetHostname(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectGetURI", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectGetURI(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectGetSysinfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectGetSysinfo(virConnectPtr @conn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectSetKeepAlive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectSetKeepAlive(virConnectPtr @conn, int @interval, uint @count);

        [DllImport(libraryPath, EntryPoint = "virConnectRegisterCloseCallback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectRegisterCloseCallback(virConnectPtr @conn, virConnectCloseFunc @cb, IntPtr @opaque, virFreeCallback @freecb);

        [DllImport(libraryPath, EntryPoint = "virConnectUnregisterCloseCallback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectUnregisterCloseCallback(virConnectPtr @conn, virConnectCloseFunc @cb);

        [DllImport(libraryPath, EntryPoint = "virConnectGetMaxVcpus", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectGetMaxVcpus(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @type);

        [DllImport(libraryPath, EntryPoint = "virNodeGetInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetInfo(virConnectPtr @conn, virNodeInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virConnectGetCapabilities", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectGetCapabilities(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virNodeGetCPUStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetCPUStats(virConnectPtr @conn, int @cpuNum, virNodeCPUStatsPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeGetMemoryStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetMemoryStats(virConnectPtr @conn, int @cellNum, virNodeMemoryStatsPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeGetFreeMemory", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern ulong virNodeGetFreeMemory(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virNodeGetSecurityModel", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetSecurityModel(virConnectPtr @conn, virSecurityModelPtr @secmodel);

        [DllImport(libraryPath, EntryPoint = "virNodeSuspendForDuration", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeSuspendForDuration(virConnectPtr @conn, uint @target, ulong @duration, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeGetCellsFreeMemory", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetCellsFreeMemory(virConnectPtr @conn, IntPtr @freeMems, int @startCell, int @maxCells);

        [DllImport(libraryPath, EntryPoint = "virConnectIsEncrypted", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectIsEncrypted(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectIsSecure", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectIsSecure(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectIsAlive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectIsAlive(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectCompareCPU", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectCompareCPU(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectGetCPUModelNames", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectGetCPUModelNames(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @arch, out IntPtr @models, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectBaselineCPU", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectBaselineCPU(virConnectPtr @conn, out IntPtr @xmlCPUs, uint @ncpus, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeGetFreePages", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeGetFreePages(virConnectPtr @conn, uint @npages, IntPtr @pages, int @startcell, uint @cellcount, IntPtr @counts, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeAllocPages", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeAllocPages(virConnectPtr @conn, uint @npages, IntPtr @pageSizes, IntPtr @pageCounts, int @startCell, uint @cellCount, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetSchedulerParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetSchedulerParameters(virDomainPtr @domain, virTypedParameterPtr @params, IntPtr @nparams);

        [DllImport(libraryPath, EntryPoint = "virDomainGetSchedulerParametersFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetSchedulerParametersFlags(virDomainPtr @domain, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetSchedulerParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetSchedulerParameters(virDomainPtr @domain, virTypedParameterPtr @params, int @nparams);

        [DllImport(libraryPath, EntryPoint = "virDomainSetSchedulerParametersFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetSchedulerParametersFlags(virDomainPtr @domain, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainMigrate(virDomainPtr @domain, virConnectPtr @dconn, int @flags, [MarshalAs(UnmanagedType.LPStr)] string @dname, [MarshalAs(UnmanagedType.LPStr)] string @uri, int @bandwidth);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrate2", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainMigrate2(virDomainPtr @domain, virConnectPtr @dconn, [MarshalAs(UnmanagedType.LPStr)] string @dxml, int @flags, [MarshalAs(UnmanagedType.LPStr)] string @dname, [MarshalAs(UnmanagedType.LPStr)] string @uri, int @bandwidth);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrate3", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainMigrate3(virDomainPtr @domain, virConnectPtr @dconn, virTypedParameterPtr @params, uint @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateToURI", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateToURI(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @duri, int @flags, [MarshalAs(UnmanagedType.LPStr)] string @dname, int @bandwidth);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateToURI2", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateToURI2(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @dconnuri, [MarshalAs(UnmanagedType.LPStr)] string @miguri, [MarshalAs(UnmanagedType.LPStr)] string @dxml, int @flags, [MarshalAs(UnmanagedType.LPStr)] string @dname, int @bandwidth);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateToURI3", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateToURI3(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @dconnuri, virTypedParameterPtr @params, uint @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateSetMaxDowntime", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateSetMaxDowntime(virDomainPtr @domain, ulong @downtime, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateGetCompressionCache", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateGetCompressionCache(virDomainPtr @domain, IntPtr @cacheSize, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateSetCompressionCache", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateSetCompressionCache(virDomainPtr @domain, ulong @cacheSize, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateSetMaxSpeed", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateSetMaxSpeed(virDomainPtr @domain, int @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMigrateGetMaxSpeed", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMigrateGetMaxSpeed(virDomainPtr @domain, IntPtr @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectGetDomainCapabilities", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectGetDomainCapabilities(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @emulatorbin, [MarshalAs(UnmanagedType.LPStr)] string @arch, [MarshalAs(UnmanagedType.LPStr)] string @machine, [MarshalAs(UnmanagedType.LPStr)] string @virttype, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectListDomains", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListDomains(virConnectPtr @conn, out int[] @ids, int @maxids);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfDomains", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfDomains(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virDomainGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virDomainGetConnect(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainCreateXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCreateXMLWithFiles", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainCreateXMLWithFiles(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @nfiles, IntPtr @files, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virDomainLookupByID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainLookupByID(virConnectPtr @conn, int @id);

        [DllImport(libraryPath, EntryPoint = "virDomainLookupByUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainLookupByUUID(virConnectPtr @conn, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virDomainLookupByUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainLookupByUUIDString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @uuid);

        [DllImport(libraryPath, EntryPoint = "virDomainShutdown", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainShutdown(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainShutdownFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainShutdownFlags(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainReboot", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainReboot(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainReset", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainReset(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainDestroy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainDestroy(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainDestroyFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainDestroyFlags(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainRef(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainFree(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainSuspend", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSuspend(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainResume", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainResume(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainPMSuspendForDuration", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainPMSuspendForDuration(virDomainPtr @domain, uint @target, ulong @duration, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainPMWakeup", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainPMWakeup(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSave", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSave(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @to);

        [DllImport(libraryPath, EntryPoint = "virDomainSaveFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSaveFlags(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @to, [MarshalAs(UnmanagedType.LPStr)] string @dxml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainRestore", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainRestore(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @from);

        [DllImport(libraryPath, EntryPoint = "virDomainRestoreFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainRestoreFlags(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @from, [MarshalAs(UnmanagedType.LPStr)] string @dxml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSaveImageGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainSaveImageGetXMLDesc(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @file, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSaveImageDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSaveImageDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @file, [MarshalAs(UnmanagedType.LPStr)] string @dxml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainManagedSave", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainManagedSave(virDomainPtr @dom, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainHasManagedSaveImage", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainHasManagedSaveImage(virDomainPtr @dom, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainManagedSaveRemove", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainManagedSaveRemove(virDomainPtr @dom, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCoreDump", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainCoreDump(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @to, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCoreDumpWithFormat", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainCoreDumpWithFormat(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @to, uint @dumpformat, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainScreenshot", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainScreenshot(virDomainPtr @domain, virStreamPtr @stream, uint @screen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetInfo(virDomainPtr @domain, virDomainInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virDomainGetState", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetState(virDomainPtr @domain, IntPtr @state, IntPtr @reason, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetCPUStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetCPUStats(virDomainPtr @domain, virTypedParameterPtr @params, uint @nparams, int @start_cpu, uint @ncpus, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetControlInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetControlInfo(virDomainPtr @domain, virDomainControlInfoPtr @info, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetSchedulerType", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainGetSchedulerType(virDomainPtr @domain, IntPtr @nparams);

        [DllImport(libraryPath, EntryPoint = "virDomainSetBlkioParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetBlkioParameters(virDomainPtr @domain, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetBlkioParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetBlkioParameters(virDomainPtr @domain, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMemoryParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMemoryParameters(virDomainPtr @domain, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetMemoryParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetMemoryParameters(virDomainPtr @domain, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetNumaParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetNumaParameters(virDomainPtr @domain, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetNumaParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetNumaParameters(virDomainPtr @domain, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virDomainGetName(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainGetID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern uint virDomainGetID(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainGetUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetUUID(virDomainPtr @domain, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virDomainGetUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetUUIDString(virDomainPtr @domain, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virDomainGetOSType", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainGetOSType(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainGetMaxMemory", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetMaxMemory(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMaxMemory", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMaxMemory(virDomainPtr @domain, int @memory);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMemory", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMemory(virDomainPtr @domain, int @memory);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMemoryFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMemoryFlags(virDomainPtr @domain, int @memory, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMemoryStatsPeriod", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMemoryStatsPeriod(virDomainPtr @domain, int @period, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetMaxVcpus", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetMaxVcpus(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainGetSecurityLabel", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetSecurityLabel(virDomainPtr @domain, virSecurityLabelPtr @seclabel);

        [DllImport(libraryPath, EntryPoint = "virDomainGetHostname", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainGetHostname(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetSecurityLabelList", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetSecurityLabelList(virDomainPtr @domain, IntPtr @seclabels);

        [DllImport(libraryPath, EntryPoint = "virDomainSetMetadata", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetMetadata(virDomainPtr @domain, int @type, [MarshalAs(UnmanagedType.LPStr)] string @metadata, [MarshalAs(UnmanagedType.LPStr)] string @key, [MarshalAs(UnmanagedType.LPStr)] string @uri, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetMetadata", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainGetMetadata(virDomainPtr @domain, int @type, [MarshalAs(UnmanagedType.LPStr)] string @uri, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainGetXMLDesc(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainXMLFromNative", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectDomainXMLFromNative(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @nativeFormat, [MarshalAs(UnmanagedType.LPStr)] string @nativeConfig, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainXMLToNative", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectDomainXMLToNative(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @nativeFormat, [MarshalAs(UnmanagedType.LPStr)] string @domainXml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockStats(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virDomainBlockStatsPtr @stats, UIntPtr @size);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockStatsFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockStatsFlags(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainInterfaceStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainInterfaceStats(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @path, virDomainInterfaceStatsPtr @stats, UIntPtr @size);

        [DllImport(libraryPath, EntryPoint = "virDomainSetInterfaceParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetInterfaceParameters(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @device, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetInterfaceParameters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetInterfaceParameters(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @device, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockPeek", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockPeek(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, ulong @offset, UIntPtr @size, IntPtr @buffer, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockResize", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockResize(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, ulong @size, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetBlockInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetBlockInfo(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virDomainBlockInfoPtr @info, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMemoryStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMemoryStats(virDomainPtr @dom, virDomainMemoryStatPtr @stats, uint @nr_stats, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainMemoryPeek", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainMemoryPeek(virDomainPtr @dom, ulong @start, UIntPtr @size, IntPtr @buffer, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xml);

        [DllImport(libraryPath, EntryPoint = "virDomainDefineXMLFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainDefineXMLFlags(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainUndefine(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainUndefineFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainUndefineFlags(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfDefinedDomains", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfDefinedDomains(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListDefinedDomains", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListDefinedDomains(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllDomains", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllDomains(virConnectPtr @conn, out IntPtr @domains, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCreate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainCreate(virDomainPtr @domain);

        [DllImport(libraryPath, EntryPoint = "virDomainCreateWithFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainCreateWithFlags(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCreateWithFiles", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainCreateWithFiles(virDomainPtr @domain, uint @nfiles, IntPtr @files, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetAutostart(virDomainPtr @domain, IntPtr @autostart);

        [DllImport(libraryPath, EntryPoint = "virDomainSetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetAutostart(virDomainPtr @domain, int @autostart);

        [DllImport(libraryPath, EntryPoint = "virDomainSetVcpus", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetVcpus(virDomainPtr @domain, uint @nvcpus);

        [DllImport(libraryPath, EntryPoint = "virDomainSetVcpusFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetVcpusFlags(virDomainPtr @domain, uint @nvcpus, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetVcpusFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetVcpusFlags(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainPinVcpu", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainPinVcpu(virDomainPtr @domain, uint @vcpu, IntPtr @cpumap, int @maplen);

        [DllImport(libraryPath, EntryPoint = "virDomainPinVcpuFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainPinVcpuFlags(virDomainPtr @domain, uint @vcpu, IntPtr @cpumap, int @maplen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetVcpuPinInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetVcpuPinInfo(virDomainPtr @domain, int @ncpumaps, IntPtr @cpumaps, int @maplen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainPinEmulator", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainPinEmulator(virDomainPtr @domain, IntPtr @cpumap, int @maplen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetEmulatorPinInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetEmulatorPinInfo(virDomainPtr @domain, IntPtr @cpumaps, int @maplen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetVcpus", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetVcpus(virDomainPtr @domain, virVcpuInfoPtr @info, int @maxinfo, IntPtr @cpumaps, int @maplen);

        [DllImport(libraryPath, EntryPoint = "virDomainAttachDevice", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainAttachDevice(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xml);

        [DllImport(libraryPath, EntryPoint = "virDomainDetachDevice", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainDetachDevice(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xml);

        [DllImport(libraryPath, EntryPoint = "virDomainAttachDeviceFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainAttachDeviceFlags(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainDetachDeviceFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainDetachDeviceFlags(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainUpdateDeviceFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainUpdateDeviceFlags(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectGetAllDomainStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectGetAllDomainStats(virConnectPtr @conn, uint @stats, out IntPtr @retStats, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainListGetStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainListGetStats(IntPtr @doms, uint @stats, out IntPtr @retStats, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainStatsRecordListFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virDomainStatsRecordListFree(IntPtr @stats);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockJobAbort", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockJobAbort(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetBlockJobInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetBlockJobInfo(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virDomainBlockJobInfoPtr @info, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockJobSetSpeed", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockJobSetSpeed(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, int @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockPull", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockPull(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, int @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockRebase", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockRebase(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, [MarshalAs(UnmanagedType.LPStr)] string @base, int @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockCopy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockCopy(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, [MarshalAs(UnmanagedType.LPStr)] string @destxml, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainBlockCommit", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainBlockCommit(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, [MarshalAs(UnmanagedType.LPStr)] string @base, [MarshalAs(UnmanagedType.LPStr)] string @top, int @bandwidth, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetBlockIoTune", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetBlockIoTune(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virTypedParameterPtr @params, int @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetBlockIoTune", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetBlockIoTune(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @disk, virTypedParameterPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetDiskErrors", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetDiskErrors(virDomainPtr @dom, virDomainDiskErrorPtr @errors, uint @maxerrors, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSendKey", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSendKey(virDomainPtr @domain, uint @codeset, uint @holdtime, IntPtr @keycodes, int @nkeycodes, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSendProcessSignal", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSendProcessSignal(virDomainPtr @domain, long @pid_value, uint @signum, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainCreateLinux", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainCreateLinux(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainEventRegister", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectDomainEventRegister(virConnectPtr @conn, virConnectDomainEventCallback @cb, IntPtr @opaque, virFreeCallback @freecb);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainEventDeregister", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectDomainEventDeregister(virConnectPtr @conn, virConnectDomainEventCallback @cb);

        [DllImport(libraryPath, EntryPoint = "virDomainIsActive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainIsActive(virDomainPtr @dom);

        [DllImport(libraryPath, EntryPoint = "virDomainIsPersistent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainIsPersistent(virDomainPtr @dom);

        [DllImport(libraryPath, EntryPoint = "virDomainIsUpdated", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainIsUpdated(virDomainPtr @dom);

        [DllImport(libraryPath, EntryPoint = "virDomainGetJobInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetJobInfo(virDomainPtr @dom, virDomainJobInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virDomainGetJobStats", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetJobStats(virDomainPtr @domain, IntPtr @type, IntPtr @params, IntPtr @nparams, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainAbortJob", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainAbortJob(virDomainPtr @dom);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainEventRegisterAny", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectDomainEventRegisterAny(virConnectPtr @conn, virDomainPtr @dom, int @eventID, virConnectDomainEventGenericCallback @cb, IntPtr @opaque, virFreeCallback @freecb);

        [DllImport(libraryPath, EntryPoint = "virConnectDomainEventDeregisterAny", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectDomainEventDeregisterAny(virConnectPtr @conn, int @callbackID);

        [DllImport(libraryPath, EntryPoint = "virDomainOpenConsole", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainOpenConsole(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @dev_name, virStreamPtr @st, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainOpenChannel", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainOpenChannel(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @name, virStreamPtr @st, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainOpenGraphics", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainOpenGraphics(virDomainPtr @dom, uint @idx, int @fd, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainOpenGraphicsFD", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainOpenGraphicsFD(virDomainPtr @dom, uint @idx, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainInjectNMI", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainInjectNMI(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainFSTrim", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainFSTrim(virDomainPtr @dom, [MarshalAs(UnmanagedType.LPStr)] string @mountPoint, ulong @minimum, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainFSFreeze", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainFSFreeze(virDomainPtr @dom, out IntPtr @mountpoints, uint @nmountpoints, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainFSThaw", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainFSThaw(virDomainPtr @dom, out IntPtr @mountpoints, uint @nmountpoints, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainFSInfoFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virDomainFSInfoFree(virDomainFSInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virDomainGetFSInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetFSInfo(virDomainPtr @dom, out IntPtr @info, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainGetTime", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainGetTime(virDomainPtr @dom, IntPtr @seconds, IntPtr @nseconds, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSetTime", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSetTime(virDomainPtr @dom, long @seconds, uint @nseconds, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virDomainSnapshotGetName(virDomainSnapshotPtr @snapshot);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotGetDomain", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainPtr virDomainSnapshotGetDomain(virDomainSnapshotPtr @snapshot);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virDomainSnapshotGetConnect(virDomainSnapshotPtr @snapshot);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainSnapshotPtr virDomainSnapshotCreateXML(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virDomainSnapshotGetXMLDesc(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotNum", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotNum(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotListNames", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotListNames(virDomainPtr @domain, out IntPtr @names, int @nameslen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainListAllSnapshots", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainListAllSnapshots(virDomainPtr @domain, out IntPtr @snaps, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotNumChildren", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotNumChildren(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotListChildrenNames", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotListChildrenNames(virDomainSnapshotPtr @snapshot, out IntPtr @names, int @nameslen, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotListAllChildren", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotListAllChildren(virDomainSnapshotPtr @snapshot, out IntPtr @snaps, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainSnapshotPtr virDomainSnapshotLookupByName(virDomainPtr @domain, [MarshalAs(UnmanagedType.LPStr)] string @name, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainHasCurrentSnapshot", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainHasCurrentSnapshot(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotCurrent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainSnapshotPtr virDomainSnapshotCurrent(virDomainPtr @domain, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotGetParent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virDomainSnapshotPtr virDomainSnapshotGetParent(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotIsCurrent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotIsCurrent(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotHasMetadata", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotHasMetadata(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainRevertToSnapshot", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainRevertToSnapshot(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotDelete", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotDelete(virDomainSnapshotPtr @snapshot, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotRef(virDomainSnapshotPtr @snapshot);

        [DllImport(libraryPath, EntryPoint = "virDomainSnapshotFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virDomainSnapshotFree(virDomainSnapshotPtr @snapshot);

        [DllImport(libraryPath, EntryPoint = "virEventRegisterImpl", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virEventRegisterImpl(virEventAddHandleFunc @addHandle, virEventUpdateHandleFunc @updateHandle, virEventRemoveHandleFunc @removeHandle, virEventAddTimeoutFunc @addTimeout, virEventUpdateTimeoutFunc @updateTimeout, virEventRemoveTimeoutFunc @removeTimeout);

        [DllImport(libraryPath, EntryPoint = "virEventRegisterDefaultImpl", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventRegisterDefaultImpl();

        [DllImport(libraryPath, EntryPoint = "virEventRunDefaultImpl", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventRunDefaultImpl();

        [DllImport(libraryPath, EntryPoint = "virEventAddHandle", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventAddHandle(int @fd, int @events, virEventHandleCallback @cb, IntPtr @opaque, virFreeCallback @ff);

        [DllImport(libraryPath, EntryPoint = "virEventUpdateHandle", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virEventUpdateHandle(int @watch, int @events);

        [DllImport(libraryPath, EntryPoint = "virEventRemoveHandle", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventRemoveHandle(int @watch);

        [DllImport(libraryPath, EntryPoint = "virEventAddTimeout", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventAddTimeout(int @frequency, virEventTimeoutCallback @cb, IntPtr @opaque, virFreeCallback @ff);

        [DllImport(libraryPath, EntryPoint = "virEventUpdateTimeout", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virEventUpdateTimeout(int @timer, int @frequency);

        [DllImport(libraryPath, EntryPoint = "virEventRemoveTimeout", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virEventRemoveTimeout(int @timer);

        [DllImport(libraryPath, EntryPoint = "virInterfaceGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virInterfaceGetConnect(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfInterfaces", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfInterfaces(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListInterfaces", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListInterfaces(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfDefinedInterfaces", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfDefinedInterfaces(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListDefinedInterfaces", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListDefinedInterfaces(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllInterfaces", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllInterfaces(virConnectPtr @conn, out IntPtr @ifaces, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virInterfacePtr virInterfaceLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virInterfaceLookupByMACString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virInterfacePtr virInterfaceLookupByMACString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @mac);

        [DllImport(libraryPath, EntryPoint = "virInterfaceGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virInterfaceGetName(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virInterfaceGetMACString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virInterfaceGetMACString(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virInterfaceGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virInterfaceGetXMLDesc(virInterfacePtr @iface, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virInterfacePtr virInterfaceDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceUndefine(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virInterfaceCreate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceCreate(virInterfacePtr @iface, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceDestroy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceDestroy(virInterfacePtr @iface, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceRef(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virInterfaceFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceFree(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virInterfaceChangeBegin", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceChangeBegin(virConnectPtr @conn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceChangeCommit", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceChangeCommit(virConnectPtr @conn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceChangeRollback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceChangeRollback(virConnectPtr @conn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virInterfaceIsActive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virInterfaceIsActive(virInterfacePtr @iface);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virNetworkGetConnect(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfNetworks", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfNetworks(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListNetworks", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListNetworks(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfDefinedNetworks", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfDefinedNetworks(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListDefinedNetworks", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListDefinedNetworks(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllNetworks", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllNetworks(virConnectPtr @conn, out IntPtr @nets, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNetworkLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNetworkPtr virNetworkLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virNetworkLookupByUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNetworkPtr virNetworkLookupByUUID(virConnectPtr @conn, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virNetworkLookupByUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNetworkPtr virNetworkLookupByUUIDString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @uuid);

        [DllImport(libraryPath, EntryPoint = "virNetworkCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNetworkPtr virNetworkCreateXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc);

        [DllImport(libraryPath, EntryPoint = "virNetworkDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNetworkPtr virNetworkDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc);

        [DllImport(libraryPath, EntryPoint = "virNetworkUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkUndefine(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkUpdate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkUpdate(virNetworkPtr @network, uint @command, uint @section, int @parentIndex, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNetworkCreate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkCreate(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkDestroy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkDestroy(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkRef(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkFree(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virNetworkGetName(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkGetUUID(virNetworkPtr @network, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkGetUUIDString(virNetworkPtr @network, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virNetworkGetXMLDesc(virNetworkPtr @network, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetBridgeName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virNetworkGetBridgeName(virNetworkPtr @network);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkGetAutostart(virNetworkPtr @network, IntPtr @autostart);

        [DllImport(libraryPath, EntryPoint = "virNetworkSetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkSetAutostart(virNetworkPtr @network, int @autostart);

        [DllImport(libraryPath, EntryPoint = "virNetworkIsActive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkIsActive(virNetworkPtr @net);

        [DllImport(libraryPath, EntryPoint = "virNetworkIsPersistent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkIsPersistent(virNetworkPtr @net);

        [DllImport(libraryPath, EntryPoint = "virNetworkDHCPLeaseFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern void virNetworkDHCPLeaseFree(virNetworkDHCPLeasePtr @lease);

        [DllImport(libraryPath, EntryPoint = "virNetworkGetDHCPLeases", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNetworkGetDHCPLeases(virNetworkPtr @network, [MarshalAs(UnmanagedType.LPStr)] string @mac, out IntPtr @leases, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectNetworkEventRegisterAny", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNetworkEventRegisterAny(virConnectPtr @conn, virNetworkPtr @net, int @eventID, virConnectNetworkEventGenericCallback @cb, IntPtr @opaque, virFreeCallback @freecb);

        [DllImport(libraryPath, EntryPoint = "virConnectNetworkEventDeregisterAny", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNetworkEventDeregisterAny(virConnectPtr @conn, int @callbackID);

        [DllImport(libraryPath, EntryPoint = "virNodeNumOfDevices", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeNumOfDevices(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @cap, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeListDevices", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeListDevices(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @cap, out IntPtr @names, int @maxnames, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllNodeDevices", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllNodeDevices(virConnectPtr @conn, out IntPtr @devices, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNodeDevicePtr virNodeDeviceLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceLookupSCSIHostByWWN", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNodeDevicePtr virNodeDeviceLookupSCSIHostByWWN(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @wwnn, [MarshalAs(UnmanagedType.LPStr)] string @wwpn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virNodeDeviceGetName(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceGetParent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virNodeDeviceGetParent(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceNumOfCaps", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceNumOfCaps(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceListCaps", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceListCaps(virNodeDevicePtr @dev, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virNodeDeviceGetXMLDesc(virNodeDevicePtr @dev, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceRef(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceFree(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceDettach", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceDettach(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceDetachFlags", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceDetachFlags(virNodeDevicePtr @dev, [MarshalAs(UnmanagedType.LPStr)] string @driverName, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceReAttach", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceReAttach(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceReset", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceReset(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNodeDevicePtr virNodeDeviceCreateXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNodeDeviceDestroy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNodeDeviceDestroy(virNodeDevicePtr @dev);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfNWFilters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfNWFilters(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListNWFilters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListNWFilters(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllNWFilters", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllNWFilters(virConnectPtr @conn, out IntPtr @filters, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virNWFilterLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNWFilterPtr virNWFilterLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virNWFilterLookupByUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNWFilterPtr virNWFilterLookupByUUID(virConnectPtr @conn, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virNWFilterLookupByUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNWFilterPtr virNWFilterLookupByUUIDString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @uuid);

        [DllImport(libraryPath, EntryPoint = "virNWFilterDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virNWFilterPtr virNWFilterDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc);

        [DllImport(libraryPath, EntryPoint = "virNWFilterUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNWFilterUndefine(virNWFilterPtr @nwfilter);

        [DllImport(libraryPath, EntryPoint = "virNWFilterRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNWFilterRef(virNWFilterPtr @nwfilter);

        [DllImport(libraryPath, EntryPoint = "virNWFilterFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNWFilterFree(virNWFilterPtr @nwfilter);

        [DllImport(libraryPath, EntryPoint = "virNWFilterGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virNWFilterGetName(virNWFilterPtr @nwfilter);

        [DllImport(libraryPath, EntryPoint = "virNWFilterGetUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNWFilterGetUUID(virNWFilterPtr @nwfilter, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virNWFilterGetUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virNWFilterGetUUIDString(virNWFilterPtr @nwfilter, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virNWFilterGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virNWFilterGetXMLDesc(virNWFilterPtr @nwfilter, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virSecretGetConnect(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfSecrets", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfSecrets(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListSecrets", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListSecrets(virConnectPtr @conn, out IntPtr @uuids, int @maxuuids);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllSecrets", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllSecrets(virConnectPtr @conn, out IntPtr @secrets, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretLookupByUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virSecretPtr virSecretLookupByUUID(virConnectPtr @conn, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virSecretLookupByUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virSecretPtr virSecretLookupByUUIDString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @uuid);

        [DllImport(libraryPath, EntryPoint = "virSecretLookupByUsage", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virSecretPtr virSecretLookupByUsage(virConnectPtr @conn, int @usageType, [MarshalAs(UnmanagedType.LPStr)] string @usageID);

        [DllImport(libraryPath, EntryPoint = "virSecretDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virSecretPtr virSecretDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xml, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretGetUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretGetUUID(virSecretPtr @secret, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virSecretGetUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretGetUUIDString(virSecretPtr @secret, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virSecretGetUsageType", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretGetUsageType(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virSecretGetUsageID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virSecretGetUsageID(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virSecretGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virSecretGetXMLDesc(virSecretPtr @secret, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretSetValue", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretSetValue(virSecretPtr @secret, IntPtr @value, UIntPtr @value_size, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretGetValue", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virSecretGetValue(virSecretPtr @secret, IntPtr @value_size, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virSecretUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretUndefine(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virSecretRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretRef(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virSecretFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virSecretFree(virSecretPtr @secret);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virStoragePoolGetConnect(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfStoragePools", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfStoragePools(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListStoragePools", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListStoragePools(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectNumOfDefinedStoragePools", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectNumOfDefinedStoragePools(virConnectPtr @conn);

        [DllImport(libraryPath, EntryPoint = "virConnectListDefinedStoragePools", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListDefinedStoragePools(virConnectPtr @conn, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virConnectListAllStoragePools", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virConnectListAllStoragePools(virConnectPtr @conn, out IntPtr @pools, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virConnectFindStoragePoolSources", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virConnectFindStoragePoolSources(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @type, [MarshalAs(UnmanagedType.LPStr)] string @srcSpec, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolLookupByName(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolLookupByUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolLookupByUUID(virConnectPtr @conn, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolLookupByUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolLookupByUUIDString(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @uuid);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolLookupByVolume", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolLookupByVolume(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolCreateXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolDefineXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStoragePoolPtr virStoragePoolDefineXML(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @xmlDesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolBuild", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolBuild(virStoragePoolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolUndefine", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolUndefine(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolCreate", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolCreate(virStoragePoolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolDestroy", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolDestroy(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolDelete", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolDelete(virStoragePoolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolRef(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolFree(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolRefresh", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolRefresh(virStoragePoolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virStoragePoolGetName(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetUUID", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolGetUUID(virStoragePoolPtr @pool, IntPtr @uuid);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetUUIDString", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolGetUUIDString(virStoragePoolPtr @pool, IntPtr @buf);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolGetInfo(virStoragePoolPtr @vol, virStoragePoolInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virStoragePoolGetXMLDesc(virStoragePoolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolGetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolGetAutostart(virStoragePoolPtr @pool, IntPtr @autostart);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolSetAutostart", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolSetAutostart(virStoragePoolPtr @pool, int @autostart);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolNumOfVolumes", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolNumOfVolumes(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolListVolumes", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolListVolumes(virStoragePoolPtr @pool, out IntPtr @names, int @maxnames);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolListAllVolumes", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolListAllVolumes(virStoragePoolPtr @pool, out IntPtr @vols, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetConnect", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virConnectPtr virStorageVolGetConnect(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolLookupByName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStorageVolPtr virStorageVolLookupByName(virStoragePoolPtr @pool, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "virStorageVolLookupByKey", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStorageVolPtr virStorageVolLookupByKey(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @key);

        [DllImport(libraryPath, EntryPoint = "virStorageVolLookupByPath", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStorageVolPtr virStorageVolLookupByPath(virConnectPtr @conn, [MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetName", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virStorageVolGetName(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetKey", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern string virStorageVolGetKey(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolCreateXML", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStorageVolPtr virStorageVolCreateXML(virStoragePoolPtr @pool, [MarshalAs(UnmanagedType.LPStr)] string @xmldesc, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolCreateXMLFrom", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStorageVolPtr virStorageVolCreateXMLFrom(virStoragePoolPtr @pool, [MarshalAs(UnmanagedType.LPStr)] string @xmldesc, virStorageVolPtr @clonevol, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolDownload", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolDownload(virStorageVolPtr @vol, virStreamPtr @stream, ulong @offset, ulong @length, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolUpload", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolUpload(virStorageVolPtr @vol, virStreamPtr @stream, ulong @offset, ulong @length, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolDelete", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolDelete(virStorageVolPtr @vol, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolWipe", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolWipe(virStorageVolPtr @vol, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolWipePattern", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolWipePattern(virStorageVolPtr @vol, uint @algorithm, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolRef(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolFree(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetInfo", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolGetInfo(virStorageVolPtr @vol, virStorageVolInfoPtr @info);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetXMLDesc", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virStorageVolGetXMLDesc(virStorageVolPtr @pool, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStorageVolGetPath", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern IntPtr virStorageVolGetPath(virStorageVolPtr @vol);

        [DllImport(libraryPath, EntryPoint = "virStorageVolResize", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStorageVolResize(virStorageVolPtr @vol, ulong @capacity, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolIsActive", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolIsActive(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStoragePoolIsPersistent", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStoragePoolIsPersistent(virStoragePoolPtr @pool);

        [DllImport(libraryPath, EntryPoint = "virStreamNew", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern virStreamPtr virStreamNew(virConnectPtr @conn, uint @flags);

        [DllImport(libraryPath, EntryPoint = "virStreamRef", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamRef(virStreamPtr @st);

        [DllImport(libraryPath, EntryPoint = "virStreamSend", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamSend(virStreamPtr @st, [MarshalAs(UnmanagedType.LPStr)] string @data, UIntPtr @nbytes);

        [DllImport(libraryPath, EntryPoint = "virStreamRecv", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamRecv(virStreamPtr @st, IntPtr @data, UIntPtr @nbytes);

        [DllImport(libraryPath, EntryPoint = "virStreamSendAll", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamSendAll(virStreamPtr @st, virStreamSourceFunc @handler, IntPtr @opaque);

        [DllImport(libraryPath, EntryPoint = "virStreamRecvAll", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamRecvAll(virStreamPtr @st, virStreamSinkFunc @handler, IntPtr @opaque);

        [DllImport(libraryPath, EntryPoint = "virStreamEventAddCallback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamEventAddCallback(virStreamPtr @stream, int @events, virStreamEventCallback @cb, IntPtr @opaque, virFreeCallback @ff);

        [DllImport(libraryPath, EntryPoint = "virStreamEventUpdateCallback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamEventUpdateCallback(virStreamPtr @stream, int @events);

        [DllImport(libraryPath, EntryPoint = "virStreamEventRemoveCallback", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamEventRemoveCallback(virStreamPtr @stream);

        [DllImport(libraryPath, EntryPoint = "virStreamFinish", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamFinish(virStreamPtr @st);

        [DllImport(libraryPath, EntryPoint = "virStreamAbort", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamAbort(virStreamPtr @st);

        [DllImport(libraryPath, EntryPoint = "virStreamFree", CallingConvention = CallingConvention.Cdecl, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public static extern int virStreamFree(virStreamPtr @st);

    }
}
