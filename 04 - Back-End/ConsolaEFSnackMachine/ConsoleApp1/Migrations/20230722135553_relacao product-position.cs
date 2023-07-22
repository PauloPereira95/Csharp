using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class relacaoproductposition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PositionProduct",
                columns: table => new
                {
                    PositionsIDPosition = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductIDProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionProduct", x => new { x.PositionsIDPosition, x.ProductIDProduct });
                    table.ForeignKey(
                        name: "FK_PositionProduct_Position_PositionsIDPosition",
                        column: x => x.PositionsIDPosition,
                        principalTable: "Position",
                        principalColumn: "IDPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionProduct_Product_ProductIDProduct",
                        column: x => x.ProductIDProduct,
                        principalTable: "Product",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PositionProduct_ProductIDProduct",
                table: "PositionProduct",
                column: "ProductIDProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionProduct");
        }
    }
}
