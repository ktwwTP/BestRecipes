using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class FavouriteSeed : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.HasData(
                new Favourite
                {
                    Id = 1,
                    UserId = 1,
                    RecipeId = 2,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Favourite
                {
                    Id = 2,
                    UserId = 2,
                    RecipeId = 3,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Favourite
                {
                    Id = 3,
                    UserId = 3,
                    RecipeId = 1,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            );
        }
    }
}
