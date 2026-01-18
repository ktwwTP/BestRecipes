using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecipeImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3369), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3370), "/images/Pancakes-9493.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3371), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3372), "/images/2025-04-10-ceasar-salad-dressing-v02-00-00-31-23-still020-680fd1894dad3.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3373), new DateTime(2026, 1, 18, 8, 24, 25, 602, DateTimeKind.Utc).AddTicks(3373), "/images/IMG_7696-er-720x1008.jpg" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "effc9282-d3cc-4c60-be8d-961e804e6686", "AQAAAAIAAYagAAAAEBjKhQZ2YX5AvP2oyK9FstH19t4RpeCi5foesvJoAlbJDuSCNnwS8XBG6QYtgnySMA==", "697ba9fc-866c-422a-8707-3c67453d9db1" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9309), new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9322), new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9324), new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9805), new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9807), new DateTime(2026, 1, 18, 16, 6, 8, 198, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9887), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9888), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9890), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9960), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9962), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9963), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9592), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9592), null });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9593), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9594), null });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ImageUrl" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9595), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9595), null });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9665), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9666), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9669), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9668), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9671), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9675), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9674), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9676), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9678), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9679), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9680), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9682), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9683), new DateTime(2026, 1, 18, 8, 6, 8, 198, DateTimeKind.Utc).AddTicks(9683) });
        }
    }
}
