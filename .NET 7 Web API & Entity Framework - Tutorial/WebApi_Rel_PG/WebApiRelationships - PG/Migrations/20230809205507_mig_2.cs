using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRelationships___PG.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Characters_CharacterId",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction");

            migrationBuilder.DropIndex(
                name: "IX_CharacterFaction_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Character");

            migrationBuilder.RenameColumn(
                name: "charactersId",
                table: "CharacterFaction",
                newName: "CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction",
                columns: new[] { "CharacterId", "FactionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_FactionsId",
                table: "CharacterFaction",
                column: "FactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Character_CharacterId",
                table: "Backpacks",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Character_CharacterId",
                table: "CharacterFaction",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Character_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backpacks_Character_CharacterId",
                table: "Backpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Character_CharacterId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Character_CharacterId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction");

            migrationBuilder.DropIndex(
                name: "IX_CharacterFaction_FactionsId",
                table: "CharacterFaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "Characters");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "CharacterFaction",
                newName: "charactersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction",
                columns: new[] { "FactionsId", "charactersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_charactersId",
                table: "CharacterFaction",
                column: "charactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backpacks_Characters_CharacterId",
                table: "Backpacks",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction",
                column: "charactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
