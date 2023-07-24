using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachinePosition_Position_IDPosition",
                table: "MachinePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionProduct_Position_IDPosition",
                table: "PositionProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Orders_IDProduto",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_IDProduto",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionProduct",
                table: "PositionProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachinePosition",
                table: "MachinePosition");

            migrationBuilder.DropColumn(
                name: "IDProduto",
                table: "Product");

            migrationBuilder.AddColumn<Guid>(
                name: "IDProduct",
                table: "PositionProduct",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IDMachine",
                table: "MachinePosition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionProduct",
                table: "PositionProduct",
                columns: new[] { "IDPosition", "IDProduct" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachinePosition",
                table: "MachinePosition",
                columns: new[] { "IDMachine", "IDPosition" });

            migrationBuilder.CreateIndex(
                name: "IX_PositionProduct_IDProduct",
                table: "PositionProduct",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_MachinePosition_IDPosition",
                table: "MachinePosition",
                column: "IDPosition");

            migrationBuilder.AddForeignKey(
                name: "FK_MachinePosition_Position_IDMachine",
                table: "MachinePosition",
                column: "IDMachine",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionProduct_Position_IDProduct",
                table: "PositionProduct",
                column: "IDProduct",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Orders_IDProduct",
                table: "Product",
                column: "IDProduct",
                principalTable: "Orders",
                principalColumn: "IDOrder",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachinePosition_Position_IDMachine",
                table: "MachinePosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionProduct_Position_IDProduct",
                table: "PositionProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Orders_IDProduct",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionProduct",
                table: "PositionProduct");

            migrationBuilder.DropIndex(
                name: "IX_PositionProduct_IDProduct",
                table: "PositionProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachinePosition",
                table: "MachinePosition");

            migrationBuilder.DropIndex(
                name: "IX_MachinePosition_IDPosition",
                table: "MachinePosition");

            migrationBuilder.DropColumn(
                name: "IDProduct",
                table: "PositionProduct");

            migrationBuilder.DropColumn(
                name: "IDMachine",
                table: "MachinePosition");

            migrationBuilder.AddColumn<Guid>(
                name: "IDProduto",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionProduct",
                table: "PositionProduct",
                column: "IDPosition");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachinePosition",
                table: "MachinePosition",
                column: "IDPosition");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IDProduto",
                table: "Product",
                column: "IDProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_MachinePosition_Position_IDPosition",
                table: "MachinePosition",
                column: "IDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionProduct_Position_IDPosition",
                table: "PositionProduct",
                column: "IDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Orders_IDProduto",
                table: "Product",
                column: "IDProduto",
                principalTable: "Orders",
                principalColumn: "IDOrder");
        }
    }
}
