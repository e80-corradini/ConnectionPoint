using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class VpnDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SslCertificate { get; set; }

        public long VpnTypeId { get; set; }
        public  VpnTypeDTO VpnType { get; set; }
        public  ICollection<HandoverDTO> Handovers { get; set; }
    }
}
