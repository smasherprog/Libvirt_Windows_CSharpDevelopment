
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt
{
    public class Host : IDisposable
    {
        public static readonly int MAX_INTERFACE_NAMES = 24;
        private Libvirt.virConnectPtr _ConnectPtr;
        public Libvirt.virConnectPtr ConnectPtr { get { return _ConnectPtr; } }
        public bool IsValid { get { return _ConnectPtr.Pointer != IntPtr.Zero; } }
        public Host(Libvirt.virConnectPtr ptr)
        {
            _ConnectPtr = ptr;
        }
        public string virConnectBaselineCPU(string[] xmlCPUs, virConnectBaselineCPUFlags flags)
        {
            return API.virConnectBaselineCPU(ConnectPtr, xmlCPUs, Convert.ToUInt32(xmlCPUs.Length), flags);
        }
        public int virConnectCompareCPU(out string @xmlDesc, virConnectCompareCPUFlags @flags)
        {
            return API.virConnectCompareCPU(ConnectPtr, out @xmlDesc, @flags);
        }
        public int virConnectGetCPUModelNames(string arch, out string[] models)
        {
            return API.virConnectGetCPUModelNames(ConnectPtr, arch, out models);
        }
        public string virConnectGetCapabilities()
        {
            return API.virConnectGetCapabilities(ConnectPtr);
        }
        public string virConnectGetHostname()
        {
            return API.virConnectGetHostname(ConnectPtr);
        }

        public int virConnectGetLibVersion(out uint libVer)
        {
            return API.virConnectGetLibVersion(ConnectPtr, out libVer);
        }
        public int virConnectGetMaxVcpus(string type)
        {
            return API.virConnectGetMaxVcpus(ConnectPtr, type);
        }
        public string virConnectGetSysinfo(uint @flags = 0)
        {
            return API.virConnectGetSysinfo(ConnectPtr, @flags);
        }
        public string virConnectGetType()
        {
            return API.virConnectGetType(ConnectPtr);
        }
        public string virConnectGetURI()
        {
            return API.virConnectGetURI(ConnectPtr);
        }
        public int virConnectGetVersion(ref int hvVer)
        {
            return API.virConnectGetVersion(ConnectPtr, ref hvVer);
        }
        public int virConnectIsAlive()
        {
            return API.virConnectIsAlive(ConnectPtr);
        }
        public int virConnectIsEncrypted()
        {
            return API.virConnectIsEncrypted(ConnectPtr);
        }
        public int virConnectIsSecure()
        {
            return API.virConnectIsSecure(ConnectPtr);
        }
        public static async Task<Host> virConnectOpen(string name)
        {
            var h = await API.virConnectOpen(name);
            return new Host(h);
        }
        public static async Task<Host> virConnectOpenReadOnly(string @name)
        {
            var h = await API.virConnectOpenReadOnly(name);
            return new Host(h);
        }
        public static async Task<Host> virConnectOpenAuth(string @name, _virConnectAuth @auth, virConnectFlags @flags)
        {
            var h = await API.virConnectOpenAuth(@name, @auth, @flags);
            return new Host(h);
        }

        public int virConnectRegisterCloseCallback(virConnectCloseFunc cb)
        {
            return API.virConnectRegisterCloseCallback(ConnectPtr, cb, IntPtr.Zero, API._Dummy_virFreeCallback);
        }
        public int virConnectSetKeepAlive(int interval, uint count)
        {
            return API.virConnectSetKeepAlive(ConnectPtr, interval, count);
        }
        public int virConnectUnregisterCloseCallback(virConnectCloseFunc cb)
        {
            return API.virConnectUnregisterCloseCallback(ConnectPtr, cb);
        }
        public int virGetVersion(ref uint[] libVer)
        {
            return API.virGetVersion(ref libVer);
        }
        public int virNodeAllocPages(uint[] pageSizes, ulong[] pageCounts, int startCell, uint cellCount, virNodeAllocPagesFlags flags)
        {
            return API.virNodeAllocPages(ConnectPtr, Convert.ToUInt32(pageSizes.Length), pageSizes, pageCounts, startCell, cellCount, flags);
        }
        public int virNodeGetCPUMap(out bool[] cpumap)
        {
            int count = 0;
            return API.virNodeGetCPUMap(ConnectPtr, out cpumap, out count);
        }

        public int virNodeGetCPUStats(int @cpuNum /*-1 for all cpus on host */, out _virNodeCPUStats[] @params)
        {
            int count = 0;
            return API.virNodeGetCPUStats(ConnectPtr, @cpuNum, out @params, count);
        }
        public int virNodeGetCellsFreeMemory(ulong[] freeMems, int startCell, int maxCells)
        {
            return API.virNodeGetCellsFreeMemory(ConnectPtr, freeMems, startCell, maxCells);
        }
        public ulong virNodeGetFreeMemory()
        {
            return API.virNodeGetFreeMemory(ConnectPtr);
        }
        public int virNodeGetFreePages(uint[] pages, int startCell, uint cellCount, out ulong[] counts)
        {
            counts = new ulong[pages.Length * cellCount];
            return API.virNodeGetFreePages(ConnectPtr, Convert.ToUInt32(pages.Length), pages, startCell, cellCount, counts);
        }
        public int virNodeGetInfo(out _virNodeInfo @info)
        {
            return API.virNodeGetInfo(ConnectPtr, out info);
        }
        public int virNodeGetMemoryParameters(out _virTypedParameter[] pars)
        {
            int count = 0;
            return API.virNodeGetMemoryParameters(ConnectPtr, out pars, ref count);
        }

        public int virNodeGetMemoryStats(int @cellNum/*-1 for all memory info on host */, out _virNodeMemoryStats[] pars)
        {
            int count = 0;
            return API.virNodeGetMemoryStats(ConnectPtr, cellNum, out pars, ref count);
        }
        public int virNodeGetSecurityModel(out _virSecurityModel secmodel)
        {
            return API.virNodeGetSecurityModel(ConnectPtr, out secmodel);
        }
        public int virNodeSetMemoryParameters(_virTypedParameter[] pars)
        {
            return API.virNodeSetMemoryParameters(ConnectPtr, pars, pars.Length);
        }
        public int virNodeSuspendForDuration(uint target, ulong duration)
        {
            return API.virNodeSuspendForDuration(ConnectPtr, target, duration);
        }

        public int virConnectListAllInterfaces(out virInterfacePtr[] ifaces, virConnectListAllInterfacesFlags flags)
        {
            return API.virConnectListAllInterfaces(ConnectPtr, out ifaces, flags);
        }
        public int virConnectListDefinedInterfaces(out string[] names)
        {
            return API.virConnectListDefinedInterfaces(ConnectPtr, out names, MAX_INTERFACE_NAMES);
        }
        public int virConnectListInterfaces(out string[] names)
        {
            return API.virConnectListInterfaces(ConnectPtr, out names, MAX_INTERFACE_NAMES);
        }
        public int virConnectNumOfDefinedInterfaces()
        {
            return API.virConnectNumOfDefinedInterfaces(ConnectPtr);
        }
        public int virConnectNumOfInterfaces()
        {
            return API.virConnectNumOfInterfaces(ConnectPtr);
        }
        public int virInterfaceChangeBegin()
        {
            return API.virInterfaceChangeBegin(ConnectPtr);
        }
        public int virInterfaceChangeCommit()
        {
            return API.virInterfaceChangeCommit(ConnectPtr);
        }
        public int virInterfaceChangeRollback()
        {
            return API.virInterfaceChangeRollback(ConnectPtr);
        }


        public void Dispose()
        {
            ConnectPtr.Dispose();
        }

    }
}
