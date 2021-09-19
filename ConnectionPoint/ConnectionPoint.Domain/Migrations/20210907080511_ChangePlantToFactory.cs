using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionPoint.Domain.Migrations
{
    public partial class ChangePlantToFactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Customers");
        }
    }
}
