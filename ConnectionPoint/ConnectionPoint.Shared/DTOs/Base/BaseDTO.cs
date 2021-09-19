using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared.DTOs
{
    public class BaseDTO
    {
        public long Id { get; set; }
        public EEntityStatus Status { get; set; }
        public DateTime InsertDateTime { get; set; } = DateTime.Now;
        public DateTime? LastUpdateDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public string LastUpdateNote { get; set; }
    }

    public enum EEntityStatus : short 
    {
        New=0,
        PendingApproval=1,
        Approved=2,
        Rejected=3
    }
}
