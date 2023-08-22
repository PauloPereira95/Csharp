using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiSnackMachine.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Support_Intervection_IntervectionIDIntervection",
                table: "Support");

            migrationBuilder.DropIndex(
                name: "IX_Support_IntervectionIDIntervection",
                table: "Support");

            migrationBuilder.DropColumn(
                name: "IntervectionIDIntervection",
                table: "Support");

            migrationBuilder.CreateTable(
                name: "IntervectionSupport",
                columns: table => new
                {
                    IntervectionIDIntervection = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupportIDSupport = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntervectionSupport", x => new { x.IntervectionIDIntervection, x.SupportIDSupport });
                    table.ForeignKey(
                        name: "FK_IntervectionSupport_Intervection_IntervectionIDIntervection",
                        column: x => x.IntervectionIDIntervection,
                        principalTable: "Intervection",
                        principalColumn: "IDIntervection",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntervectionSupport_Support_SupportIDSupport",
                        column: x => x.SupportIDSupport,
                        principalTable: "Support",
                        principalColumn: "IDSupport",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntervectionSupport_SupportIDSupport",
                table: "IntervectionSupport",
                column: "SupportIDSupport");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntervectionSupport");

            migrationBuilder.AddColumn<Guid>(
                name: "IntervectionIDIntervection",
                table: "Support",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Support_IntervectionIDIntervection",
                table: "Support",
                column: "IntervectionIDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_Support_Intervection_IntervectionIDIntervection",
                table: "Support",
                column: "IntervectionIDIntervection",
                principalTable: "Intervection",
                principalColumn: "IDIntervection");
        }
    }
}
