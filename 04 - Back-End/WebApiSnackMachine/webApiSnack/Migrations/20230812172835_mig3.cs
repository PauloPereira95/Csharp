using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiSnack.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Money_MoneyIDMoney",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_MoneyIDMoney",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "MoneyIDMoney",
                table: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Money_Customer_IDMoney",
                table: "Money",
                column: "IDMoney",
                principalTable: "Customer",
                principalColumn: "IDCostumer",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Money_Customer_IDMoney",
                table: "Money");

            migrationBuilder.AddColumn<Guid>(
                name: "MoneyIDMoney",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MoneyIDMoney",
                table: "Customer",
                column: "MoneyIDMoney");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Money_MoneyIDMoney",
                table: "Customer",
                column: "MoneyIDMoney",
                principalTable: "Money",
                principalColumn: "IDMoney");
        }
    }
}
