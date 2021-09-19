using ConnectionPoint.Domain.Context;
using ConnectionPoint.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionPoint.Domain
{
    public class ConnectionPointContext : IdentityDbContext, IConnectionPointContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Handover> Handovers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Vpn> Vpns { get; set; }
        public virtual DbSet<VpnType> VpnTypes { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }

        public ConnectionPointContext(DbContextOptions<ConnectionPointContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(x => x.Projects)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            modelBuilder.Entity<Project>()
                .HasMany(x => x.Handovers)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.ProjectId);

            modelBuilder.Entity<Handover>()
                .HasMany(x => x.Devices)
                .WithOne(x => x.Handover)
                .HasForeignKey(x => x.HandoverId);

            modelBuilder.Entity<Project>()
                .HasOne(x => x.Vpn)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.VpnId);


            modelBuilder.Entity<Vpn>()
                .HasOne(x => x.VpnType)
                .WithMany(x => x.Vpns)
                .HasForeignKey(x => x.VpnTypeId);

            modelBuilder.Entity<Device>()
                .HasOne(x => x.DeviceType)
                .WithMany(x => x.Devices)
                .HasForeignKey(x => x.DeviceTypeId);
        }
    }
}
