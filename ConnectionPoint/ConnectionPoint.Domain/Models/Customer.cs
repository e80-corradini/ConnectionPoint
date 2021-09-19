using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Models
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

    }
}
