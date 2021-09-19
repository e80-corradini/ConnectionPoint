﻿// <auto-generated />
using System;
using ConnectionPoint.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConnectionPoint.Domain.Migrations
{
    [DbContext(typeof(ConnectionPointContext))]
    [Migration("20210907080511_ChangePlantToFactory")]
    partial class ChangePlantToFactory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PlantId")
                        .HasColumnType("bigint");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Device", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlternativeDns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FQDN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gateway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HandoverId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrincipalDns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Subnet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HandoverId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Factory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Handover", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<long>("VpnId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("VpnId");

                    b.ToTable("Handovers");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PlantId")
                        .HasColumnType("bigint");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Vpn", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SslCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("VpnTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("VpnTypeId");

                    b.ToTable("Vpns");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.VpnType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdateNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("VpnTypes");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Device", b =>
                {
                    b.HasOne("ConnectionPoint.Domain.Models.Handover", "Handover")
                        .WithMany("Devices")
                        .HasForeignKey("HandoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Handover");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Factory", b =>
                {
                    b.HasOne("ConnectionPoint.Domain.Models.Customer", "Customer")
                        .WithMany("Plants")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Handover", b =>
                {
                    b.HasOne("ConnectionPoint.Domain.Models.Project", "Project")
                        .WithMany("Handovers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConnectionPoint.Domain.Models.Vpn", "Vpn")
                        .WithMany("Handovers")
                        .HasForeignKey("VpnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Vpn");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Project", b =>
                {
                    b.HasOne("ConnectionPoint.Domain.Models.Factory", "Plant")
                        .WithMany("Projects")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Vpn", b =>
                {
                    b.HasOne("ConnectionPoint.Domain.Models.VpnType", "VpnType")
                        .WithMany("Vpns")
                        .HasForeignKey("VpnTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VpnType");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Customer", b =>
                {
                    b.Navigation("Plants");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Factory", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Handover", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Project", b =>
                {
                    b.Navigation("Handovers");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.Vpn", b =>
                {
                    b.Navigation("Handovers");
                });

            modelBuilder.Entity("ConnectionPoint.Domain.Models.VpnType", b =>
                {
                    b.Navigation("Vpns");
                });
#pragma warning restore 612, 618
        }
    }
}
