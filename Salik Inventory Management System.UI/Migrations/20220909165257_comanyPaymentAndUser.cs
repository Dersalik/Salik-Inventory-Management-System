using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salik_Inventory_Management_System.UI.Migrations
{
    public partial class comanyPaymentAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ItemPriceBought",
                table: "Items",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MardCompanyId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "mardCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMoneyOwedByUserToTheCompany = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mardCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalMoneyOwedByCustomers = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalMoneyReceivedFromCustomers = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companyPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MardCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_companyPayments_mardCompany_MardCompanyId",
                        column: x => x.MardCompanyId,
                        principalTable: "mardCompany",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_MardCompanyId",
                table: "Items",
                column: "MardCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_companyPayments_MardCompanyId",
                table: "companyPayments",
                column: "MardCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_mardCompany_MardCompanyId",
                table: "Items",
                column: "MardCompanyId",
                principalTable: "mardCompany",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_mardCompany_MardCompanyId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "companyPayments");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "mardCompany");

            migrationBuilder.DropIndex(
                name: "IX_Items_MardCompanyId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemPriceBought",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MardCompanyId",
                table: "Items");
        }
    }
}
