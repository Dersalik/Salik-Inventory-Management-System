using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salik_Inventory_Management_System.UI.Migrations
{
    public partial class GainedAmountMoey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalGainedMoney",
                table: "User",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalGainedMoney",
                table: "User");
        }
    }
}
