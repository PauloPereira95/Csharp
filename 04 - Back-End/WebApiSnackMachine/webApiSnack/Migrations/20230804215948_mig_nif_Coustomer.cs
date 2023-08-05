using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApiSnack.Migrations
{
    /// <inheritdoc />
    public partial class mig_nif_Coustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nif",
                table: "Customer",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nif",
                table: "Customer");
        }
    }
}
