
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.CS_Objects
{
    public class Host : IDisposable
    {
        private Libvirt.virConnectPtr _ConnectPtr;
        public bool IsValid { get { return _ConnectPtr.Pointer != IntPtr.Zero; } }
        public Host(Libvirt.virConnectPtr ptr)
        {
            _ConnectPtr = ptr;
        }
        public string virConnectBaselineCPU(string[] xmlCPUs, virConnectBaselineCPUFlags flags)
        {
            return API.virConnectBaselineCPU(_ConnectPtr, xmlCPUs, Convert.ToUInt32(xmlCPUs.Length), flags);
        }
        public int virConnectCompareCPU(out string @xmlDesc, virConnectCompareCPUFlags @flags)
        {
            return API.virConnectCompareCPU(_ConnectPtr, out @xmlDesc, @flags);
        }
        public int virConnectGetCPUModelNames(string arch, out string[] models)
        {
            return API.virConnectGetCPUModelNames(_ConnectPtr, arch, out models);
        }
        public string virConnectGetCapabilities()
        {
            return API.virConnectGetCapabilities(_ConnectPtr);
        }
        public string virConnectGetHostname()
        {
            return API.virConnectGetHostname(_ConnectPtr);
        }

        public int virConnectGetLibVersion(out uint libVer)
        {
            return API.virConnectGetLibVersion(_ConnectPtr, out libVer);
        }
        public int virConnectGetMaxVcpus(string type)
        {
            return API.virConnectGetMaxVcpus(_ConnectPtr, type);
        }
        public string virConnectGetSysinfo(uint @flags = 0)
        {
            return API.virConnectGetSysinfo(_ConnectPtr, @flags);
        }
        public string virConnectGetType()
        {
            return API.virConnectGetType(_ConnectPtr);
        }
        public string virConnectGetURI()
        {
            return API.virConnectGetURI(_ConnectPtr);
        }
        public int virConnectGetVersion(ref int hvVer)
        {
            return API.virConnectGetVersion(_ConnectPtr, ref hvVer);
        }
        public int virConnectIsAlive()
        {
            return API.virConnectIsAlive(_ConnectPtr);
        }
        public int virConnectIsEncrypted()
        {
            return API.virConnectIsEncrypted(_ConnectPtr);
        }
        public int virConnectIsSecure()
        {
            return API.virConnectIsSecure(_ConnectPtr);
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
            return API.virConnectRegisterCloseCallback(_ConnectPtr, cb, IntPtr.Zero, API._Dummy_virFreeCallback);
        }
        public int virConnectSetKeepAlive(int interval, uint count)
        {
            return API.virConnectSetKeepAlive(_ConnectPtr, interval, count);
        }
        public int virConnectUnregisterCloseCallback(virConnectCloseFunc cb)
        {
            return API.virConnectUnregisterCloseCallback(_ConnectPtr, cb);
        }
        public int virGetVersion(ref uint[] libVer)
        {
            return API.virGetVersion(ref libVer);
        }
        public int virNodeAllocPages(uint[] pageSizes, ulong[] pageCounts, int startCell, uint cellCount, virNodeAllocPagesFlags flags)
        {
            return API.virNodeAllocPages(_ConnectPtr, Convert.ToUInt32(pageSizes.Length), pageSizes, pageCounts, startCell, cellCount, flags);
        }
        public int virNodeGetCPUMap(out bool[] cpumap)
        {
            int count = 0;
            return API.virNodeGetCPUMap(_ConnectPtr, out cpumap, out count);
        }

        public int virNodeGetCPUStats(int @cpuNum /*-1 for all cpus on host */, out _virNodeCPUStats[] @params)
        {
            int count = 0;
            return API.virNodeGetCPUStats(_ConnectPtr, @cpuNum, out @params, count);
        }
        public int virNodeGetCellsFreeMemory(ulong[] freeMems, int startCell, int maxCells)
        {
            return API.virNodeGetCellsFreeMemory(_ConnectPtr, freeMems, startCell, maxCells);
        }
        public ulong virNodeGetFreeMemory()
        {
            return API.virNodeGetFreeMemory(_ConnectPtr);
        }
        public int virNodeGetFreePages(uint[] pages, int startCell, uint cellCount, out ulong[] counts)
        {
            counts = new ulong[pages.Length * cellCount];
            return API.virNodeGetFreePages(_ConnectPtr, Convert.ToUInt32(pages.Length), pages, startCell, cellCount, counts);
        }
        public int virNodeGetInfo(out _virNodeInfo @info)
        {
            return API.virNodeGetInfo(_ConnectPtr, out info);
        }
        public int virNodeGetMemoryParameters(out virTypedParameter[] pars)
        {
            int count = 0;
            return API.virNodeGetMemoryParameters(_ConnectPtr, out pars, ref count);
        }

        public int virNodeGetMemoryStats(int @cellNum/*-1 for all memory info on host */, out _virNodeMemoryStats[] pars)
        {
            int count = 0;
            return API.virNodeGetMemoryStats(_ConnectPtr, cellNum, out pars, ref count);
        }
        public int virNodeGetSecurityModel(out _virSecurityModel secmodel)
        {
            return API.virNodeGetSecurityModel(_ConnectPtr, out secmodel);
        }
        public int virNodeSetMemoryParameters(_virTypedParameter[] pars)
        {
            return API.virNodeSetMemoryParameters(_ConnectPtr, pars, pars.Length);
        }
        public int virNodeSuspendForDuration(uint target, ulong duration)
        {
            return API.virNodeSuspendForDuration(_ConnectPtr, target, duration);
        }
        //Interface stuff
        public Interface virInterfaceLookupByMACString(string mac)
        {
            return new Interface(API.virInterfaceLookupByMACString(_ConnectPtr, mac));
        }
        public Interface virInterfaceDefineXML(string xml)
        {
            return new Interface(API.virInterfaceDefineXML(_ConnectPtr, xml));
        }
        public Interface virInterfaceLookupByName(string name)
        {
            return new Interface(API.virInterfaceLookupByName(_ConnectPtr, name));
        }

        public int virConnectListAllInterfaces(out virInterfacePtr[] ifaces, virConnectListAllInterfacesFlags flags)
        {
            return API.virConnectListAllInterfaces(_ConnectPtr, out ifaces, flags);
        }
        public int virConnectListDefinedInterfaces(out string[] names, int maxnames)
        {
            return API.virConnectListDefinedInterfaces(_ConnectPtr, out names, maxnames);
        }
        public int virConnectListInterfaces(out string[] names, int maxnames)
        {
            return API.virConnectListInterfaces(_ConnectPtr, out names, maxnames);
        }
        public int virConnectNumOfDefinedInterfaces()
        {
            return API.virConnectNumOfDefinedInterfaces(_ConnectPtr);
        }
        public int virConnectNumOfInterfaces()
        {
            return API.virConnectNumOfInterfaces(_ConnectPtr);
        }
        public int virInterfaceChangeBegin()
        {
            return API.virInterfaceChangeBegin(_ConnectPtr);
        }
        public int virInterfaceChangeCommit()
        {
            return API.virInterfaceChangeCommit(_ConnectPtr);
        }
        public int virInterfaceChangeRollback()
        {
            return API.virInterfaceChangeRollback(_ConnectPtr);
        }
        //Storage stuff
        public Storage_Pool virStoragePoolCreateXML(string xmlDesc)
        {
            return new Storage_Pool(API.virStoragePoolCreateXML(_ConnectPtr, xmlDesc));
        }
        public Storage_Pool virStoragePoolDefineXML(string xml)
        {
            return new Storage_Pool(API.virStoragePoolDefineXML(_ConnectPtr, xml));
        }
        public Storage_Pool virStoragePoolLookupByName(string name)
        {
            return new Storage_Pool(API.virStoragePoolLookupByName(_ConnectPtr, name));
        }
        public Storage_Pool virStoragePoolLookupByUUID(byte[] uuid)
        {
            return new Storage_Pool(API.virStoragePoolLookupByUUID(_ConnectPtr, uuid));
        }
        public Storage_Pool virStoragePoolLookupByUUIDString(string uuid)
        {
            return new Storage_Pool(API.virStoragePoolLookupByUUIDString(_ConnectPtr, uuid));
        }

        public string virConnectFindStoragePoolSources(string type, string srcSpec)
        {
            return API.virConnectFindStoragePoolSources(_ConnectPtr, type, srcSpec);
        }
        public int virConnectListAllStoragePools(out Storage_Pool[] pools, virConnectListAllStoragePoolsFlags flags)
        {
            virStoragePoolPtr[] ptrs;
            var ret = API.virConnectListAllStoragePools(_ConnectPtr, out ptrs, flags);
            pools = new Storage_Pool[ptrs.Length];
            for (var i = 0; i < ptrs.Length; i++)
            {
                pools[i] = new Storage_Pool(ptrs[i]);
            }
            return ret;
        }
        public int virConnectListDefinedStoragePools(out string[] names, int maxnames)
        {
            return API.virConnectListDefinedStoragePools(_ConnectPtr, out names, maxnames);
        }
        public int virConnectListStoragePoolsout(string[] names, int maxnames)
        {
            return API.virConnectListStoragePools(_ConnectPtr, out names, maxnames);
        }
        public int virConnectNumOfDefinedStoragePools()
        {
            return API.virConnectNumOfDefinedStoragePools(_ConnectPtr);
        }
        public int virConnectNumOfStoragePools()
        {
            return API.virConnectNumOfStoragePools(_ConnectPtr);
        }
        //STORAGE VOLUME
        public Storage_Volume virStorageVolLookupByKey(string key)
        {
            return new Storage_Volume(API.virStorageVolLookupByKey(_ConnectPtr, key));
        }
        public Storage_Volume virStorageVolLookupByPath(string path)
        {
            return new Storage_Volume(API.virStorageVolLookupByPath(_ConnectPtr, path));
        }
        //STREAM
        public Stream virStreamNew(virStreamFlags flags)
        {
            return new Stream(API.virStreamNew(_ConnectPtr, flags));
        }
        //ERROR
        public int virConnCopyLastError(out virError to)
        {
            return API.virConnCopyLastError(_ConnectPtr, out to);
        }
        public virError virConnGetLastError()
        {
            return API.virConnGetLastError(_ConnectPtr);
        }
        public void virConnResetLastError()
        {
            API.virConnResetLastError(_ConnectPtr);
        }
        public void virConnSetErrorFunc(virErrorFunc handler)
        {
            API.virConnSetErrorFunc(_ConnectPtr, IntPtr.Zero, handler);
        }
        //DOMAIN
        public string virConnectDomainXMLFromNative(string nativeFormat, string nativeConfig)
        {
            return API.virConnectDomainXMLFromNative(_ConnectPtr, nativeFormat, nativeConfig);
        }
        public string virConnectDomainXMLToNative(string nativeFormat, string domainXml)
        {
            return API.virConnectDomainXMLToNative(_ConnectPtr, nativeFormat, domainXml);
        }
        public int virConnectGetAllDomainStats(virConnectPtr conn,
                             uint stats,
                             virDomainStatsRecordPtr retStats,
                             uint flags)
        {
            throw new NotImplementedException();
        }
        public string virConnectGetDomainCapabilities(string emulatorbin, string arch, string machine, string virttype)
        {
            return API.virConnectGetDomainCapabilities(_ConnectPtr, emulatorbin, arch, machine, virttype);
        }
        public int virConnectListAllDomains(out virDomainPtr[] domains, virConnectListAllDomainsFlags flags)
        {
            return API.virConnectListAllDomains(_ConnectPtr, out domains, flags);
        }
        public int virConnectListDefinedDomains(virConnectPtr conn, out string[] names, int maxnames)
        {
            return API.virConnectListDefinedDomains(_ConnectPtr, out names, maxnames);
        }
        public int virConnectListDomains(out int[] ids, int maxids)
        {
            return API.virConnectListDomains(_ConnectPtr, out ids, maxids);
        }
        public int virConnectNumOfDefinedDomains()
        {
            return API.virConnectNumOfDefinedDomains(_ConnectPtr);
        }
        public int virConnectNumOfDomains()
        {
            return API.virConnectNumOfDomains(_ConnectPtr);
        }


        public Domain virDomainLookupByID(int id)
        {
            return new Domain(API.virDomainLookupByID(_ConnectPtr, id));
        }
        public Domain virDomainLookupByName(string name)
        {
            return new Domain(API.virDomainLookupByName(_ConnectPtr, name));
        }

        public Domain virDomainCreateLinux(string xmlDesc)
        {
            return new Domain(API.virDomainCreateLinux(_ConnectPtr, xmlDesc));
        }
        public Domain virDomainCreateXML(string xmlDesc, virDomainCreateFlags flags)
        {
            return new Domain(API.virDomainCreateXML(_ConnectPtr, xmlDesc, flags));
        }
        public Domain virDomainCreateXMLWithFiles(string xmlDesc, int[] files, virDomainCreateFlags flags)
        {
            return new Domain(API.virDomainCreateXMLWithFiles(_ConnectPtr, xmlDesc, Convert.ToUInt32(files.Length), files, flags));
        }
        public Domain virDomainDefineXML(string xml)
        {
            return new Domain(API.virDomainDefineXML(_ConnectPtr, xml));
        }
        public Domain 	virDomainDefineXMLFlags	(string xml, virDomainDefineFlags flags)
        {
            return new Domain(API.virDomainDefineXMLFlags(_ConnectPtr, xml, flags));
        }
        public int virDomainRestore(string from)
        {
            return API.virDomainRestore(_ConnectPtr, from);
        }
        public int virDomainRestoreFlags(string from, string dxml, virDomainSaveRestoreFlags flags)
        {
            return API.virDomainRestoreFlags(_ConnectPtr, from, dxml, flags);
        }
        public int virDomainSaveImageDefineXML(string to, string dxml, virDomainSaveRestoreFlags flags)
        {
            return API.virDomainSaveImageDefineXML(_ConnectPtr, to, dxml, flags);
        }
        public string virDomainSaveImageGetXMLDesc(string file, virDomainXMLFlags flags)
        {
            return API.virDomainSaveImageGetXMLDesc(_ConnectPtr, file, flags);
        }

        public static Libvirt.virConnectPtr GetPtr(Host p)
        {
            return p._ConnectPtr;
        }
        public void Dispose()
        {
            _ConnectPtr.Dispose();
        }

    }
}
