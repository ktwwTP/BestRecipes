using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class ChallengeSeed : IEntityTypeConfiguration<Challenge>
    {
        public void Configure(EntityTypeBuilder<Challenge> builder)
        {
            builder.HasData(
                new Challenge
                {
                    Id = 1,
                    Name = "Summer Salad Challenge",
                    Details = "Create the most refreshing and healthy summer salad.",
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 6, 30),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Challenge
                {
                    Id = 2,
                    Name = "Holiday Dessert Challenge",
                    Details = "Bake a delicious dessert perfect for the holiday season.",
                    StartDate = new DateTime(2024, 12, 1),
                    EndDate = new DateTime(2024, 12, 31),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
