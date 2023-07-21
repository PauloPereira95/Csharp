using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class tablesupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    IDSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    NIF = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Tele = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Adrress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.IDSupplier);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
