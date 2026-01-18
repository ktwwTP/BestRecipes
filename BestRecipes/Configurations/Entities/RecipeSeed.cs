using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class RecipeSeed : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(
                new Recipe
                {
                    Id = 1,
                    Title = "Classic Pancakes",
                    ImageUrl = "/images/Pancakes-9493.jpg",
                    Description = "Fluffy and light pancakes perfect for breakfast.",
                    Instructions = "Mix ingredients, cook on griddle, serve with syrup.",
                    CategoryId = 2,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Caesar Salad",
                    ImageUrl = "/images/2025-04-10-ceasar-salad-dressing-v02-00-00-31-23-still020-680fd1894dad3.jpg",
                    Description = "Crisp romaine lettuce with creamy Caesar dressing.",
                    Instructions = "Toss lettuce with dressing, add croutons and cheese.",
                    CategoryId = 1,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Chocolate Chip Cookies",
                    ImageUrl = "/images/IMG_7696-er-720x1008.jpg",
                    Description = "Chewy cookies loaded with chocolate chips.",
                    Instructions = "Mix dough, fold in chocolate chips, bake until golden.",
                    CategoryId = 3,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            );
        }
    }
}
