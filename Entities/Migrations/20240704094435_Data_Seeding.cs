using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Data_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "Name" },
                values: new object[,]
                {
                    { 1, "Competition_1" },
                    { 2, "Competition_2" },
                    { 3, "Competition_3" },
                    { 4, "Competition_4" },
                    { 5, "Competition_5" },
                    { 6, "Competition_6" },
                    { 7, "Competition_7" },
                    { 8, "Competition_8" },
                    { 9, "Competition_9" },
                    { 10, "Competition_10" },
                    { 11, "Competition_11" },
                    { 12, "Competition_12" },
                    { 13, "Competition_13" },
                    { 14, "Competition_14" },
                    { 15, "Competition_15" },
                    { 16, "Competition_16" },
                    { 17, "Competition_17" },
                    { 18, "Competition_18" },
                    { 19, "Competition_19" },
                    { 20, "Competition_20" }
                });

            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "CompetitorId", "CompetitionId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Karl_1" },
                    { 2, 1, "Bertil_1" },
                    { 3, 2, "Karl_2" },
                    { 4, 2, "Bertil_2" },
                    { 5, 3, "Karl_3" },
                    { 6, 3, "Bertil_3" },
                    { 7, 4, "Karl_4" },
                    { 8, 4, "Bertil_4" },
                    { 9, 5, "Karl_5" },
                    { 10, 5, "Bertil_5" },
                    { 11, 6, "Karl_6" },
                    { 12, 6, "Bertil_6" },
                    { 13, 7, "Karl_7" },
                    { 14, 7, "Bertil_7" },
                    { 15, 8, "Karl_8" },
                    { 16, 8, "Bertil_8" },
                    { 17, 9, "Karl_9" },
                    { 18, 9, "Bertil_9" },
                    { 19, 10, "Karl_10" },
                    { 20, 10, "Bertil_10" },
                    { 21, 11, "Karl_11" },
                    { 22, 11, "Bertil_11" },
                    { 23, 12, "Karl_12" },
                    { 24, 12, "Bertil_12" },
                    { 25, 13, "Karl_13" },
                    { 26, 13, "Bertil_13" },
                    { 27, 14, "Karl_14" },
                    { 28, 14, "Bertil_14" },
                    { 29, 15, "Karl_15" },
                    { 30, 15, "Bertil_15" },
                    { 31, 16, "Karl_16" },
                    { 32, 16, "Bertil_16" },
                    { 33, 17, "Karl_17" },
                    { 34, 17, "Bertil_17" },
                    { 35, 18, "Karl_18" },
                    { 36, 18, "Bertil_18" },
                    { 37, 19, "Karl_19" },
                    { 38, 19, "Bertil_19" },
                    { 39, 20, "Karl_20" },
                    { 40, 20, "Bertil_20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Competitors",
                keyColumn: "CompetitorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "CompetitionId",
                keyValue: 20);
        }
    }
}
