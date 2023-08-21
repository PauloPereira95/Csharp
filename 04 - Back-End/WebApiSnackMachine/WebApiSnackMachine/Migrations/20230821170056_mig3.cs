using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Orders_OrdersIDIntervection",
                table: "Machine");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Orders_OrderIDIntervection",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Support_Orders_OrdersIDIntervection",
                table: "Support");

            migrationBuilder.RenameColumn(
                name: "OrdersIDIntervection",
                table: "Support",
                newName: "OrdersIDOrders");

            migrationBuilder.RenameIndex(
                name: "IX_Support_OrdersIDIntervection",
                table: "Support",
                newName: "IX_Support_OrdersIDOrders");

            migrationBuilder.RenameColumn(
                name: "OrderIDIntervection",
                table: "Product",
                newName: "OrderIDOrders");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderIDIntervection",
                table: "Product",
                newName: "IX_Product_OrderIDOrders");

            migrationBuilder.RenameColumn(
                name: "IDIntervection",
                table: "Orders",
                newName: "IDOrders");

            migrationBuilder.RenameColumn(
                name: "OrdersIDIntervection",
                table: "Machine",
                newName: "OrdersIDOrders");

            migrationBuilder.RenameIndex(
                name: "IX_Machine_OrdersIDIntervection",
                table: "Machine",
                newName: "IX_Machine_OrdersIDOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Orders_OrdersIDOrders",
                table: "Machine",
                column: "OrdersIDOrders",
                principalTable: "Orders",
                principalColumn: "IDOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Orders_OrderIDOrders",
                table: "Product",
                column: "OrderIDOrders",
                principalTable: "Orders",
                principalColumn: "IDOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Support_Orders_OrdersIDOrders",
                table: "Support",
                column: "OrdersIDOrders",
                principalTable: "Orders",
                principalColumn: "IDOrders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Orders_OrdersIDOrders",
                table: "Machine");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Orders_OrderIDOrders",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Support_Orders_OrdersIDOrders",
                table: "Support");

            migrationBuilder.RenameColumn(
                name: "OrdersIDOrders",
                table: "Support",
                newName: "OrdersIDIntervection");

            migrationBuilder.RenameIndex(
                name: "IX_Support_OrdersIDOrders",
                table: "Support",
                newName: "IX_Support_OrdersIDIntervection");

            migrationBuilder.RenameColumn(
                name: "OrderIDOrders",
                table: "Product",
                newName: "OrderIDIntervection");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderIDOrders",
                table: "Product",
                newName: "IX_Product_OrderIDIntervection");

            migrationBuilder.RenameColumn(
                name: "IDOrders",
                table: "Orders",
                newName: "IDIntervection");

            migrationBuilder.RenameColumn(
                name: "OrdersIDOrders",
                table: "Machine",
                newName: "OrdersIDIntervection");

            migrationBuilder.RenameIndex(
                name: "IX_Machine_OrdersIDOrders",
                table: "Machine",
                newName: "IX_Machine_OrdersIDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Orders_OrdersIDIntervection",
                table: "Machine",
                column: "OrdersIDIntervection",
                principalTable: "Orders",
                principalColumn: "IDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Orders_OrderIDIntervection",
                table: "Product",
                column: "OrderIDIntervection",
                principalTable: "Orders",
                principalColumn: "IDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_Support_Orders_OrdersIDIntervection",
                table: "Support",
                column: "OrdersIDIntervection",
                principalTable: "Orders",
                principalColumn: "IDIntervection");
        }
    }
}
