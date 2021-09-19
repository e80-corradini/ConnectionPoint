using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class Project:BaseEntity
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public long CustomerId { get; set; }
        public long VpnId { get; set; }
        public virtual Vpn Vpn { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Handover> Handovers { get; set; }
    }
}
