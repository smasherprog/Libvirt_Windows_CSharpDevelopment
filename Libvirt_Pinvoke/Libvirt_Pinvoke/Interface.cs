using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt
{
    public class Interface : IDisposable
    {
        private virInterfacePtr _virInterfacePtr;
        public bool IsValid { get { return _virInterfacePtr.Pointer != IntPtr.Zero; } }
        public Interface(virInterfacePtr ptr)
        {
            _virInterfacePtr = ptr;
        }
        public int virInterfaceCreate()
        {
            return API.virInterfaceCreate(_virInterfacePtr);
        }
        public static Interface virInterfaceDefineXML(Host conn, string xml)
        {
            return new Interface(API.virInterfaceDefineXML(conn.ConnectPtr, xml));
        }
        public int virInterfaceDestroy()
        {
            return API.virInterfaceDestroy(_virInterfacePtr);
        }
        public string virInterfaceGetMACString()
        {
            return API.virInterfaceGetMACString(_virInterfacePtr);
        }
        public string virInterfaceGetName()
        {
            return API.virInterfaceGetName(_virInterfacePtr);
        }
        public string virInterfaceGetXMLDesc(virInterfaceXMLFlags flags)
        {
            return API.virInterfaceGetXMLDesc(_virInterfacePtr, flags);
        }
        public int virInterfaceIsActive()
        {
            return API.virInterfaceIsActive(_virInterfacePtr);
        }
        public static Interface virInterfaceLookupByMACString(Host conn, string mac)
        {
            return new Interface(API.virInterfaceLookupByMACString(conn.ConnectPtr, mac));
        }
        public static Interface virInterfaceLookupByName(Host conn, string name)
        {
            return new Interface(API.virInterfaceLookupByName(conn.ConnectPtr, name));
        }
        public int virInterfaceUndefine()
        {
            return API.virInterfaceUndefine(_virInterfacePtr);
        }
        public void Dispose()
        {
            _virInterfacePtr.Dispose();
        }

    }
}
