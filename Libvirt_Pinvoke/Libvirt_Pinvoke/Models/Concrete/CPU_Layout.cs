using Libvirt.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Concrete
{
    public class CPU_Layout : ITo_XML, IValidation
    {
        public CPU_Layout()
        {
            vCpu_Count = 1;
            Cpu_Model = "qemu64";// AGAIN, I am using a vm within a vm to test, so this must be selected as the default..
           // Socket_Count = Core_Count = Thread_Count = -1;
        }
        public int vCpu_Count { get; set; }
        public string Cpu_Model { get; set; }

        //TOPOLOGY doesnt really make any sense at this point
        //private int _Socket_Count;
        //public int Socket_Count { get { return _Socket_Count; } set { } }
        //private int _Core_Count;
        //public int Core_Count { get { return _Core_Count; } set; }
        //private int _Thread_Count;
        //public int Thread_Count { get { return _Thread_Count; } set; }

        public string To_XML()
        {
            var ret = "<vcpu placement='static'>" + vCpu_Count.ToString() + "</vcpu>";
            ret += "<cpu match='exact'>";
            ret += "<model>"+Cpu_Model+"</model>";
            ret += "</cpu>";
            //if (Socket_Count > 0 || Core_Count > 0 || Thread_Count > 0)
            //{
            //    ret += "<cpu>";
            //    ret += "<topology ";
            //    if (Socket_Count > 0) ret += "sockets='" + Socket_Count.ToString() + "' ";
            //    if (Core_Count > 0) ret += "cores='" + Core_Count.ToString() + "' ";
            //    if (Thread_Count > 0) ret += "threads='" + Thread_Count.ToString() + "' ";
            //    ret += " /></cpu>";
            //}

            return ret;
        }
        public void Validate(IValdiator v)
        {

        }
    }
}
