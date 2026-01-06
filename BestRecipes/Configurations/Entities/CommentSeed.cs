using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    Content = "This recipe is fantastic! My family loved it.",
                    RecipeId = 1,
                    UserId = 2,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 2,
                    Content = "I found the instructions a bit confusing, but the end result was great.",
                    RecipeId = 2,
                    UserId = 3,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 3,
                    Content = "Delicious! I will definitely make this again.",
                    RecipeId = 3,
                    UserId = 1,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow
                }
            );
        }
    }
}
