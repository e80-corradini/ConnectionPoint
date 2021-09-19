using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class DeviceTypeDTO: BaseDTO
    {
        public string Name { get; set; }
        public  ICollection<DeviceDTO> Devices { get; set; }

    }
}
