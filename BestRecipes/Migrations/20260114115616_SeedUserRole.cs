using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "abf70544-a8c5-4f06-be41-fc37a3d6d9c1", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIt4vB0ISYb9bdQ/539lAGuZQclsP4chwbUy1mI1mwKgu5pOnlYqFZl3SRH+HTFAgw==", null, false, "68c4c26a-3634-49cc-9b74-5f1114bac538", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7975), new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7979), new DateTime(2026, 1, 14, 19, 48, 5, 599, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8063), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8066), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8068), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8153), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8155), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8157), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8265), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8268), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8270), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8408), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8411), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8413), new DateTime(2026, 1, 14, 11, 48, 5, 599, DateTimeKind.Utc).AddTicks(8414) });
        }
    }
}
