using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class HandoverDTO: BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public long ProjectId { get; set; }
        public long VpnId { get; set; }

        public  VpnDTO Vpn { get; set; }
        public  ProjectDTO Project { get; set; }
        public  ICollection<DeviceDTO> Devices { get; set; }
    }
}
