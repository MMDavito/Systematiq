using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Competitor_Composite_Index_Changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Competitors_CompetitionId",
                table: "Competitors");

            migrationBuilder.DropIndex(
                name: "IX_Competitors_Name_CompetitionId",
                table: "Competitors");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CompetitionId_Name",
                table: "Competitors",
                columns: new[] { "CompetitionId", "Name" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Competitors_CompetitionId_Name",
                table: "Competitors");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CompetitionId",
                table: "Competitors",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_Name_CompetitionId",
                table: "Competitors",
                columns: new[] { "Name", "CompetitionId" },
                unique: true);
        }
    }
}
