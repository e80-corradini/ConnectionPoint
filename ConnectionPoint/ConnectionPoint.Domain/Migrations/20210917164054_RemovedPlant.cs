using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionPoint.Domain.Migrations
{
    public partial class RemovedPlant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Handovers_Vpns_VpnId",
                table: "Handovers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Factories_FactoryId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropIndex(
                name: "IX_Handovers_VpnId",
                table: "Handovers");

            migrationBuilder.DropColumn(
                name: "VpnId",
                table: "Handovers");

            migrationBuilder.RenameColumn(
                name: "FactoryId",
                table: "Projects",
                newName: "VpnId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_FactoryId",
                table: "Projects",
                newName: "IX_Projects_VpnId");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "Projects",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Vpns_VpnId",
                table: "Projects",
                column: "VpnId",
                principalTable: "Vpns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Vpns_VpnId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "VpnId",
                table: "Projects",
                newName: "FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_VpnId",
                table: "Projects",
                newName: "IX_Projects_FactoryId");

            migrationBuilder.AddColumn<long>(
                name: "VpnId",
                table: "Handovers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factories_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Handovers_VpnId",
                table: "Handovers",
                column: "VpnId");

            migrationBuilder.CreateIndex(
                name: "IX_Factories_CustomerId",
                table: "Factories",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Handovers_Vpns_VpnId",
                table: "Handovers",
                column: "VpnId",
                principalTable: "Vpns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Factories_FactoryId",
                table: "Projects",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
