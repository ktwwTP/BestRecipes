using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class IngredientSeed : IEntityTypeConfiguration<Ingredient>
    {   
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Sugar",
                    UpVote = 150,
                    DownVote = 10,
                    UnitOfMeasurement = "Cups",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Salt",
                    UpVote = 200,
                    DownVote = 5,
                    UnitOfMeasurement = "Teaspoons",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Flour",
                    UpVote = 180,
                    DownVote = 8,
                    UnitOfMeasurement = "Cups",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            );
        }
    }
}
