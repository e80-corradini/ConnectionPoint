using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class Vpn : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SslCertificate { get; set; }

        public long VpnTypeId { get; set; }
        public virtual VpnType VpnType { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
