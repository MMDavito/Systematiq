using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Revision_Competitors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitors_Competitions_CompetitionId",
                table: "Competitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competitions",
                table: "Competitions");

            migrationBuilder.RenameTable(
                name: "Competitions",
                newName: "Competition");

            migrationBuilder.RenameIndex(
                name: "IX_Competitions_Name",
                table: "Competition",
                newName: "IX_Competition_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competition",
                table: "Competition",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitors_Competition_CompetitionId",
                table: "Competitors",
                column: "CompetitionId",
                principalTable: "Competition",
                principalColumn: "CompetitionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitors_Competition_CompetitionId",
                table: "Competitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competition",
                table: "Competition");

            migrationBuilder.RenameTable(
                name: "Competition",
                newName: "Competitions");

            migrationBuilder.RenameIndex(
                name: "IX_Competition_Name",
                table: "Competitions",
                newName: "IX_Competitions_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competitions",
                table: "Competitions",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitors_Competitions_CompetitionId",
                table: "Competitors",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "CompetitionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
