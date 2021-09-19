using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class DeviceType: BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Device> Devices { get; set; }

    }
}
