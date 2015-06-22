using Libvirt.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Concrete
{
    public class Memory_Allocation : ITo_XML, IValidation
    {
        public Memory_Allocation()
        {
            memory = maxMemory = 128;
        }
        public int maxMemory { get; set; }//in MB
        public int memory { get; set; }//in MB
        //public int currentMemory { get; set; }//Not needed as defaults to use the Memory element if not present
        public string To_XML()
        {
            var ret = "<maxMemory unit='MB'>" + maxMemory.ToString() + "</maxMemory>";
            ret += "<memory unit='MB'>" + memory.ToString() + "</memory>";
            return ret;
        }
        public void Validate(IValdiator v)
        {

        }
    }
}
