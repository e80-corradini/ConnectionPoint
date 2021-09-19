using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FQDN { get; set; }
        public string IpAddress { get; set; }
        public string Url { get; set; }
        public string Port { get; set; }
        public string Subnet { get; set; }
        public string Gateway { get; set; }
        public string PrincipalDns { get; set; }
        public string AlternativeDns { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public long HandoverId { get; set; }
        public long DeviceTypeId { get; set; }
        public virtual Handover Handover { get; set; }
        public virtual DeviceType DeviceType { get; set; }
    }
}
