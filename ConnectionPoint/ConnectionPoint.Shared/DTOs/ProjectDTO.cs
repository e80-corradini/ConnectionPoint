using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class ProjectDTO : BaseDTO
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public long CustomerId { get; set; }

        public CustomerDTO Customer { get; set; }
        public VpnDTO Vpn { get; set; }
        public ICollection<HandoverDTO> Handovers { get; set; }
    }
}
