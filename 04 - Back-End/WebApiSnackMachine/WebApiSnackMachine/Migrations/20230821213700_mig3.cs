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
                name: "FK_IntervectionMachine_Intervection_InteractionIDIntervection",
                table: "IntervectionMachine");

            migrationBuilder.RenameColumn(
                name: "InteractionIDIntervection",
                table: "IntervectionMachine",
                newName: "IntervectionIDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_IntervectionMachine_Intervection_IntervectionIDIntervection",
                table: "IntervectionMachine",
                column: "IntervectionIDIntervection",
                principalTable: "Intervection",
                principalColumn: "IDIntervection",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntervectionMachine_Intervection_IntervectionIDIntervection",
                table: "IntervectionMachine");

            migrationBuilder.RenameColumn(
                name: "IntervectionIDIntervection",
                table: "IntervectionMachine",
                newName: "InteractionIDIntervection");

            migrationBuilder.AddForeignKey(
                name: "FK_IntervectionMachine_Intervection_InteractionIDIntervection",
                table: "IntervectionMachine",
                column: "InteractionIDIntervection",
                principalTable: "Intervection",
                principalColumn: "IDIntervection",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
