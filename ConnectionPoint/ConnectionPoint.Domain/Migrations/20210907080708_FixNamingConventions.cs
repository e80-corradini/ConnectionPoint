using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectionPoint.Domain.Migrations
{
    public partial class FixNamingConventions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Customers_CustomerId",
                table: "Plants");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Plants_PlantId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plants",
                table: "Plants");

            migrationBuilder.RenameTable(
                name: "Plants",
                newName: "Factories");

            migrationBuilder.RenameColumn(
                name: "PlantId",
                table: "Projects",
                newName: "FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_PlantId",
                table: "Projects",
                newName: "IX_Projects_FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Plants_CustomerId",
                table: "Factories",
                newName: "IX_Factories_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factories",
                table: "Factories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Customers_CustomerId",
                table: "Factories",
                column: "CustomerId",
                principalTable: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Customers_CustomerId",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Factories_FactoryId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factories",
                table: "Factories");

            migrationBuilder.RenameTable(
                name: "Factories",
                newName: "Plants");

            migrationBuilder.RenameColumn(
                name: "FactoryId",
                table: "Projects",
                newName: "PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_FactoryId",
                table: "Projects",
                newName: "IX_Projects_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Factories_CustomerId",
                table: "Plants",
                newName: "IX_Plants_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plants",
                table: "Plants",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Customers_CustomerId",
                table: "Plants",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Plants_PlantId",
                table: "Projects",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
