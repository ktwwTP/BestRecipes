using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTrending",
                table: "Recipe",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073e669e-6c59-4cd3-85a0-85befa9bd8cb", "AQAAAAIAAYagAAAAEJKDhm9mVTw95AAkRNWL7tNXgJIBHO8sClpY+tV3hqgV5/AHpzE3ALjO/BsoqiEodw==", "1e6c63d6-f94f-497c-a96a-19ce3421f207" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 56, 22, 425, DateTimeKind.Local).AddTicks(9990), new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(2), new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(5), new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(150), new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(152), new DateTime(2026, 1, 15, 0, 56, 22, 426, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(215), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(217), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(218), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(276), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(278), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(306), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(370), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(372), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(374), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsTrending" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(434), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(434), null, false });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsTrending" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(436), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(436), null, false });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl", "IsTrending" },
                values: new object[] { new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(437), new DateTime(2026, 1, 14, 16, 56, 22, 426, DateTimeKind.Utc).AddTicks(437), null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "IsTrending",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf70544-a8c5-4f06-be41-fc37a3d6d9c1", "AQAAAAIAAYagAAAAEIt4vB0ISYb9bdQ/539lAGuZQclsP4chwbUy1mI1mwKgu5pOnlYqFZl3SRH+HTFAgw==", "68c4c26a-3634-49cc-9b74-5f1114bac538" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4264), new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4286), new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4288), new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4535), new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4538), new DateTime(2026, 1, 14, 19, 56, 15, 478, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4636), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4639), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4641), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4759), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4761), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4763), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4855), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4857), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4860), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4971), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4974), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4976), new DateTime(2026, 1, 14, 11, 56, 15, 478, DateTimeKind.Utc).AddTicks(4976) });
        }
    }
}
