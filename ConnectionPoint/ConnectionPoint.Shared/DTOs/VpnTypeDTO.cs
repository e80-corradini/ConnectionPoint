using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class VpnTypeDTO: BaseDTO
    {
        public string Name { get; set; }
        public  ICollection<VpnDTO> Vpns { get; set; }

    }
}
