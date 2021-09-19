using ConnectionPoint.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain.Context
{
    public interface IConnectionPointContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Device> Devices { get; set; }
        DbSet<Handover> Handovers { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<Vpn> Vpns { get; set; }
        DbSet<VpnType> VpnTypes { get; set; }
        DbSet<DeviceType> DeviceTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
