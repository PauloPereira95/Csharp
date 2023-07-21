using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "supplier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_supplier",
                table: "supplier",
                column: "IDSupplier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_supplier",
                table: "supplier");

            migrationBuilder.RenameTable(
                name: "supplier",
                newName: "Supplier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "IDSupplier");
        }
    }
}
