using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt
{
    public class Storage : IDisposable
    {
        private Libvirt.virStoragePoolPtr _StoragePtr;
        public Libvirt.virStoragePoolPtr StoragePtr { get { return _StoragePtr; } }
        public bool IsValid { get { return _StoragePtr.Pointer != IntPtr.Zero; } }
        public Storage(Libvirt.virStoragePoolPtr ptr)
        {
            _StoragePtr = ptr;
        }
        public void Dispose()
        {
            _StoragePtr.Dispose();
        }
    }
}
