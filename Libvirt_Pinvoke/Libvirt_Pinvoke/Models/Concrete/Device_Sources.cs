using Libvirt.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Concrete
{
    public class Device_Source_Dir : IDevice_Source
    {
        public string dir_path { get; set; }
        public override string To_XML()
        {
            var ret = "<source dir='" + dir_path + "' " + base.To_XML() + ">";
            ret += "</source>";
            return ret;
        }
        public override void Validate(IValdiator v)
        {
            if (string.IsNullOrEmpty(dir_path))
            {
                v.AddError("Device_Source_Dir.dir_path", "Path cannot be empty!");
            }
        }
    }
    public class Device_Source_File : IDevice_Source
    {
        public string file_path { get; set; }
        public override string To_XML()
        {
            var ret = "<source file='" + file_path + "' " + base.To_XML() + ">";
            ret += "</source>";
            return ret;
        }
        public override void Validate(IValdiator v)
        {
            if (string.IsNullOrEmpty(file_path))
            {
                v.AddError("Device_Source_File.file_path", "Path cannot be empty!");
            }
        }
    }
    public class Device_Source_Block : IDevice_Source
    {
        public string block_path { get; set; }
        public override string To_XML()
        {
            var ret = "<source dev='" + block_path + "' " + base.To_XML() + ">";
            ret += "</source>";
            return ret;
        }
        public override void Validate(IValdiator v)
        {
            if (string.IsNullOrEmpty(block_path))
            {
                v.AddError("Device_Source_Block.block_path", "Path cannot be empty!");
            }
        }
    }
    public class Device_Source_Network : IDevice_Source
    {
        //missing auth stuff in here so it will only work with no authentication to the source target
        public Device_Source_Network()
        {
            protocol = Protocol_Types.iscsi;
        }
        public enum Protocol_Types { nbd, iscsi, rbd, sheepdog, gluster };
        public string network_path { get; set; }
        public Protocol_Types protocol { get; set; }
        public string host { get; set; }//hostname or ip address
        public override string To_XML()
        {
            var ret = "<source protocol='" + protocol.ToString() +"' name='" + network_path + "' " + base.To_XML() + ">";
            ret += "</source>";
            return ret;
        }
        public override void Validate(IValdiator v)
        {
            if (string.IsNullOrEmpty(network_path))
            {
                v.AddError("Device_Source_Network.network_path", "Path cannot be empty!");
            }
        }
    }
    public class Device_Source_Volume : IDevice_Source
    {
        //missing auth stuff in here so it will only work with no authentication to the source target
        public Device_Source_Volume()
        {

        }
        public string pool { get; set; }
        public string volume { get; set; }

        public override string To_XML()
        {
            var ret = "<source pool='" + pool + "' volume='" + volume + "' " + base.To_XML() + ">";
            ret += "</source>";
            return ret;
        }
        public override void Validate(IValdiator v)
        {
            if (string.IsNullOrEmpty(pool))
            {
                v.AddError("Device_Source_Volume.pool", "Pool cannot be empty!");
            }
            if (string.IsNullOrEmpty(volume))
            {
                v.AddError("Device_Source_Volume.volume", "Volume cannot be empty!");
            }
        }
    }
}
