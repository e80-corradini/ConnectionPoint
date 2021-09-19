using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class Handover:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public long ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
