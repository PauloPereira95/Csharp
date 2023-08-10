using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRelationships___PG.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChacterID",
                table: "Weapons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChacterID",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
