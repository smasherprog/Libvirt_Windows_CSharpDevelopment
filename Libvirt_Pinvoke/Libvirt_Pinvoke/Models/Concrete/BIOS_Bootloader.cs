using Libvirt.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Concrete
{
    public class BIOS_Bootloader : ITo_XML, IValidation
    {
        public enum Hypervisor_VM_Types { xen, linux, hvm, exe, uml };
        public enum Guest_OS_Bitness { i686, x86_64 };
        public enum Boot_Types { hd, cdrom, network };

        public BIOS_Bootloader()
        {
            type = Hypervisor_VM_Types.hvm;
            BootOrder = new List<Boot_Types>();
            BootOrder.Add(Boot_Types.hd);
            Bitness = Guest_OS_Bitness.x86_64;
            ShowBootMenu = false;
        }


        public Hypervisor_VM_Types type { get; set; }

        public List<Boot_Types> BootOrder { get; set; }
        public Guest_OS_Bitness Bitness { get; set; }
        public bool ShowBootMenu { get; set; }
        public string To_XML()
        {
            var ret = "<os>";

            ret += "<type arch='" + Bitness.ToString() + "' machine='pc'>" + type.ToString() + "</type>";//is everything a pc? I dont know.. 
            foreach (var item in BootOrder)
            {
                ret +="<boot dev='"+item.ToString()+"'/>";
            }
            if(ShowBootMenu){
                ret += "<bootmenu enable='yes' timeout='3000'/>";
            }
            ret += "</os>";
            return ret;
        }
        public void Validate(IValdiator v)
        {

        }
    }
}
