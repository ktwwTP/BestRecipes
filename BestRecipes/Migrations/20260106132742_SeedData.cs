using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7847), new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7869), "Start your meal with delicious appetizers.", "Appetizers", null },
                    { 2, null, new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7873), new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7874), "Hearty and satisfying main course recipes.", "Main Courses", null },
                    { 3, null, new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7876), new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(7877), "Sweet treats to end your meal.", "Desserts", null }
                });

            migrationBuilder.InsertData(
                table: "Challenge",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Details", "EndDate", "Name", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(8351), new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(8354), "Create the most refreshing and healthy summer salad.", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Salad Challenge", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(8357), new DateTime(2026, 1, 6, 21, 27, 41, 144, DateTimeKind.Local).AddTicks(8358), "Bake a delicious dessert perfect for the holiday season.", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holiday Dessert Challenge", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Content", "CreatedBy", "Date", "DateCreated", "DateUpdated", "RecipeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "This recipe is fantastic! My family loved it.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8576), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8577), 1, null, 2 },
                    { 2, "I found the instructions a bit confusing, but the end result was great.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8579), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8579), 2, null, 3 },
                    { 3, "Delicious! I will definitely make this again.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8581), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8582), 3, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Favourite",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "Date", "DateCreated", "DateUpdated", "RecipeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8792), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8793), 2, null, 1 },
                    { 2, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8795), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8795), 3, null, 2 },
                    { 3, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8797), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(8797), 1, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "DownVote", "Name", "UnitOfMeasurement", "UpVote", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9007), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9008), 10, "Sugar", "Cups", 150, null },
                    { 2, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9010), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9010), 5, "Salt", "Teaspoons", 200, null },
                    { 3, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9012), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9013), 8, "Flour", "Cups", 180, null }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CategoryId", "CookingDuration", "CreatedBy", "DateCreated", "DateUpdated", "Description", "IngredientId", "Instructions", "PreparationTime", "ServingSize", "Title", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 0, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9369), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9370), "Fluffy and light pancakes perfect for breakfast.", 0, "Mix ingredients, cook on griddle, serve with syrup.", 0, 0, "Classic Pancakes", null, 0 },
                    { 2, 1, 0, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9372), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9373), "Crisp romaine lettuce with creamy Caesar dressing.", 0, "Toss lettuce with dressing, add croutons and cheese.", 0, 0, "Caesar Salad", null, 0 },
                    { 3, 3, 0, null, new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9375), new DateTime(2026, 1, 6, 13, 27, 41, 144, DateTimeKind.Utc).AddTicks(9375), "Chewy cookies loaded with chocolate chips.", 0, "Mix dough, fold in chocolate chips, bake until golden.", 0, 0, "Chocolate Chip Cookies", null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Favourite",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipe");
        }
    }
}
