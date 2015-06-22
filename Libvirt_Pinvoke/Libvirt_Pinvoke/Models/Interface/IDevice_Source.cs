using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libvirt.Models.Interface
{
    public abstract class IDevice_Source : ITo_XML, IValidation
    {
        public IDevice_Source()
        {
            Source_Startup_Policy = Libvirt.Models.Concrete.Device.Source_Startup_Policies.mandatory;
        }
        public virtual string To_XML()
        {
            return "startupPolicy='" + Source_Startup_Policy.ToString() + "'";
        }
        public Libvirt.Models.Concrete.Device.Source_Startup_Policies Source_Startup_Policy { get; set; }
        public abstract void Validate(IValdiator v);
    }
}
