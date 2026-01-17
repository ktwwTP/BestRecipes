using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BestRecipes.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Challenge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpVote = table.Column<int>(type: "int", nullable: false),
                    DownVote = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTrending = table.Column<bool>(type: "bit", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    CookingDuration = table.Column<int>(type: "int", nullable: false),
                    ServingSize = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a0796e1c-2b65-4589-ae38-ec985121887d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDWQ+9BeuHocSBLyUo3jkoQz/r71LuMukpcJYnlF3LxeAbzfk5+SPiO0q78H+SRBxw==", null, false, "db7f88a0-5da8-42d0-9c7d-215913cdf74f", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5807), new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5823), "Start your meal with delicious appetizers.", "Appetizers", null },
                    { 2, null, new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5824), new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5825), "Hearty and satisfying main course recipes.", "Main Courses", null },
                    { 3, null, new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5826), new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(5826), "Sweet treats to end your meal.", "Desserts", null }
                });

            migrationBuilder.InsertData(
                table: "Challenge",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Details", "EndDate", "Name", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(6331), new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(6332), "Create the most refreshing and healthy summer salad.", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Salad Challenge", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(6334), new DateTime(2026, 1, 17, 22, 53, 31, 922, DateTimeKind.Local).AddTicks(6334), "Bake a delicious dessert perfect for the holiday season.", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holiday Dessert Challenge", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Content", "CreatedBy", "Date", "DateCreated", "DateUpdated", "RecipeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "This recipe is fantastic! My family loved it.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6432), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6432), 1, null, 2 },
                    { 2, "I found the instructions a bit confusing, but the end result was great.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6433), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6434), 2, null, 3 },
                    { 3, "Delicious! I will definitely make this again.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6435), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6435), 3, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Favourite",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "Date", "DateCreated", "DateUpdated", "RecipeId", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6500), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6501), 2, null, 1 },
                    { 2, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6502), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6502), 3, null, 2 },
                    { 3, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6503), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6504), 1, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "DownVote", "Name", "UpVote", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Pantry", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "All-Purpose Flour", 180, null },
                    { 2, "Pantry", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Granulated Sugar", 150, null },
                    { 3, "Pantry", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Olive Oil", 210, null },
                    { 4, "Dairy", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Unsalted Butter", 95, null },
                    { 5, "Dairy", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Whole Milk", 70, null },
                    { 6, "Produce", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Garlic", 300, null },
                    { 7, "Produce", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Yellow Onion", 120, null },
                    { 8, "Spices", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Kosher Salt", 400, null },
                    { 9, "Spices", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Black Pepper", 250, null }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CategoryId", "CookingDuration", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ImageUrl", "Instructions", "IsTrending", "PreparationTime", "ServingSize", "Title", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 0, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6014), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6014), "Fluffy and light pancakes perfect for breakfast.", null, "Mix ingredients, cook on griddle, serve with syrup.", false, 0, 0, "Classic Pancakes", null, 0 },
                    { 2, 1, 0, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6016), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6016), "Crisp romaine lettuce with creamy Caesar dressing.", null, "Toss lettuce with dressing, add croutons and cheese.", false, 0, 0, "Caesar Salad", null, 0 },
                    { 3, 3, 0, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6017), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6018), "Chewy cookies loaded with chocolate chips.", null, "Mix dough, fold in chocolate chips, bake until golden.", false, 0, 0, "Chocolate Chip Cookies", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "CreatedBy", "DateCreated", "DateUpdated", "Id", "Notes", "Quantity", "Unit", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6096), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6096), 0, "sifted", 200m, null, null },
                    { 2, 1, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6098), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6098), 0, "", 30m, null, null },
                    { 4, 1, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6101), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6101), 0, "melted", 50m, null, null },
                    { 5, 1, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6099), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6099), 0, "room temperature", 250m, null, null },
                    { 8, 1, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6102), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6103), 0, "pinch", 1m, null, null },
                    { 3, 2, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6106), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6107), 0, "for dressing", 50m, null, null },
                    { 7, 2, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6105), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6105), 0, "finely chopped", 0.25m, null, null },
                    { 8, 2, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6108), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6108), 0, "to taste", 1m, null, null },
                    { 9, 2, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6109), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6109), 0, "freshly ground", 1m, null, null },
                    { 1, 3, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6110), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6111), 0, "sifted", 180m, null, null },
                    { 2, 3, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6112), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6112), 0, "", 100m, null, null },
                    { 4, 3, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6113), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6113), 0, "softened", 100m, null, null },
                    { 8, 3, null, new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6114), new DateTime(2026, 1, 17, 14, 53, 31, 922, DateTimeKind.Utc).AddTicks(6115), 0, "to balance sweetness", 0.5m, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredient_IngredientId",
                table: "RecipeIngredient",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Challenge");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
