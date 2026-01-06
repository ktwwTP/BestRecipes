using BestRecipes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestRecipes.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Appetizers",
                    Description = "Start your meal with delicious appetizers.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Category
                {
                    Id = 2,
                    Name = "Main Courses",
                    Description = "Hearty and satisfying main course recipes.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Category
                {
                    Id = 3,
                    Name = "Desserts",
                    Description = "Sweet treats to end your meal.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            );
        }
    }
}
