using ConnectionPoint.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class CustomerDTO:BaseDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }

        public ICollection<ProjectDTO> Projects { get; set; }

        public CustomerDTO()
        {
            LastUpdateDateTime = DateTime.Now;
            InsertDateTime = DateTime.Now;
        }
    }
}
