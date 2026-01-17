using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class IngredientSeed : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            // Note: Ensure your Ingredient Domain class has the 'Category' property
            builder.HasData(
                // --- PANTRY ESSENTIALS ---
                new Ingredient
                {
                    Id = 1,
                    Name = "All-Purpose Flour",
                    Category = "Pantry",
                    UpVote = 180,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Granulated Sugar",
                    Category = "Pantry",
                    UpVote = 150,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Olive Oil",
                    Category = "Pantry",
                    UpVote = 210,
                    DownVote = 2,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // --- DAIRY ---
                new Ingredient
                {
                    Id = 4,
                    Name = "Unsalted Butter",
                    Category = "Dairy",
                    UpVote = 95,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Ingredient
                {
                    Id = 5,
                    Name = "Whole Milk",
                    Category = "Dairy",
                    UpVote = 70,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // --- PRODUCE ---
                new Ingredient
                {
                    Id = 6,
                    Name = "Garlic",
                    Category = "Produce",
                    UpVote = 300,
                    DownVote = 1,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Ingredient
                {
                    Id = 7,
                    Name = "Yellow Onion",
                    Category = "Produce",
                    UpVote = 120,
                    DownVote = 5,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },

                // --- SPICES ---
                new Ingredient
                {
                    Id = 8,
                    Name = "Kosher Salt",
                    Category = "Spices",
                    UpVote = 400,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                },
                new Ingredient
                {
                    Id = 9,
                    Name = "Black Pepper",
                    Category = "Spices",
                    UpVote = 250,
                    DownVote = 0,
                    DateCreated = new DateTime(2024, 1, 1),
                    DateUpdated = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}