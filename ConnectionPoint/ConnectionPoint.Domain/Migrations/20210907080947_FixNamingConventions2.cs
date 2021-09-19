using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionPoint.Domain.Migrations
{
    public partial class FixNamingConventions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PlantId",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
