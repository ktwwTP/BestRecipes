using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BestRecipes.Configurations.Entities
{
    public class RecipeIngredientSeed : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.HasData(
                // --- Classic Pancakes ---
                new RecipeIngredient
                {
                    RecipeId = 1,   // Pancakes
                    IngredientId = 1, // All-Purpose Flour
                    Quantity = 200,
                    Notes = "sifted",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 2, // Granulated Sugar
                    Quantity = 30,
                    Notes = "",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 5, // Whole Milk
                    Quantity = 250,
                    Notes = "room temperature",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 4, // Unsalted Butter
                    Quantity = 50,
                    Notes = "melted",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 1,
                    IngredientId = 8, // Kosher Salt
                    Quantity = 1,
                    Notes = "pinch",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },

                // --- Caesar Salad ---
                new RecipeIngredient
                {
                    RecipeId = 2,   // Caesar Salad
                    IngredientId = 7, // Yellow Onion (assuming used in dressing)
                    Quantity = 0.25m,
                    Notes = "finely chopped",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 3, // Olive Oil
                    Quantity = 50,
                    Notes = "for dressing",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 8, // Kosher Salt
                    Quantity = 1,
                    Notes = "to taste",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 2,
                    IngredientId = 9, // Black Pepper
                    Quantity = 1,
                    Notes = "freshly ground",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },

                // --- Chocolate Chip Cookies ---
                new RecipeIngredient
                {
                    RecipeId = 3,   // Cookies
                    IngredientId = 1, // All-Purpose Flour
                    Quantity = 180,
                    Notes = "sifted",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 3,
                    IngredientId = 2, // Granulated Sugar
                    Quantity = 100,
                    Notes = "",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 3,
                    IngredientId = 4, // Unsalted Butter
                    Quantity = 100,
                    Notes = "softened",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new RecipeIngredient
                {
                    RecipeId = 3,
                    IngredientId = 8, // Kosher Salt
                    Quantity = 0.5m,
                    Notes = "to balance sweetness",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            );
        }
    }
}