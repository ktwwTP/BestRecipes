using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(800), new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(822), new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(824), new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(1170), new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(1177), new DateTime(2026, 1, 13, 9, 54, 2, 457, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1360), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1361), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1363), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1518), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1520), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1522), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1696), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1698), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1700), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2045), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2048), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2050), new DateTime(2026, 1, 13, 1, 54, 2, 457, DateTimeKind.Utc).AddTicks(2051) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7789), new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7813), new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7816), new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(8359), new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(8367), new DateTime(2026, 1, 8, 14, 26, 56, 890, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8591), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8594), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8596), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8799), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8804), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8806), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9016), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9020), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9023), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9341), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9345), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9348), new DateTime(2026, 1, 8, 6, 26, 56, 890, DateTimeKind.Utc).AddTicks(9348) });
        }
    }
}
