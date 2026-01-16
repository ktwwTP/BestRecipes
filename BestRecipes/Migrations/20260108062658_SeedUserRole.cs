using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6835), new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6859), new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6862), new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(7282), new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(7288), new DateTime(2026, 1, 8, 14, 21, 9, 469, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7511), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7513), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7515), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7710), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7714), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7716), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7918), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7921), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7924), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8212), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8216), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8218), new DateTime(2026, 1, 8, 6, 21, 9, 469, DateTimeKind.Utc).AddTicks(8219) });
        }
    }
}
