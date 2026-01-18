using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class AddedFavouriting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7cc851-acb1-494e-8bf2-2d11e07aeadb", "AQAAAAIAAYagAAAAEDUTaf05Ybiby8iFbHKv7r4PQmy+ZyEdFw+3oK77lcwVhhOnSmpX9R5UONWOxGXltA==", "2dbc675d-c635-45b5-801f-7f3b4a339c4b" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5044), new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5059), new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5061), new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5413), new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5415), new DateTime(2026, 1, 18, 23, 38, 45, 322, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5474), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5476), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5477), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5543), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5545), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5546), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5256), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5258), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5259), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5323), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5325), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5328), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5327), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5330), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5334), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5332), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5335), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5336), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5338), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5339), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5340), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5342), new DateTime(2026, 1, 18, 15, 38, 45, 322, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b8073b-cd9b-4276-ac6e-1f5f60de47a0", "AQAAAAIAAYagAAAAELprUFBmzKC99C53gwghxGNUEbce3yJukwnuuGKqPhm27xn//LqX93pOShKL6H+UjQ==", "bc04c35c-fbe3-4564-a251-ec60133ec504" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3192), new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3211), new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3212), new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3543), new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3545), new DateTime(2026, 1, 18, 16, 24, 25, 602, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3647), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3648), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3649), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3722), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3724), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3725), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3369), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3371), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3373), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3450), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3452), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3455), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3454), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3457), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3462), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3460), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3463), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3464), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3466), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3467), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3468), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3470), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3470) });
        }
    }
}
