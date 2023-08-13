using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IDCostumer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Adress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Nif = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IDCostumer);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    IDMoney = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FiveEuro = table.Column<int>(type: "int", nullable: false),
                    OneCent = table.Column<int>(type: "int", nullable: false),
                    OneEuro = table.Column<int>(type: "int", nullable: false),
                    QuarterCent = table.Column<int>(type: "int", nullable: false),
                    TenCent = table.Column<int>(type: "int", nullable: false),
                    TwentyCent = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.IDMoney);
                    table.ForeignKey(
                        name: "FK_Money_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "IDCostumer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Money_CustomerID",
                table: "Money",
                column: "CustomerID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
