using BestRecipes.Configurations.Entities;
using BestRecipes.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BestRecipes.Data
{
    public class BestRecipesContext(DbContextOptions<BestRecipesContext> options) : IdentityDbContext<BestRecipesUser>(options)
    {
        public DbSet<BestRecipes.Domain.Category> Category { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Challenge> Challenge { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Comment> Comment { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Favourite> Favourite { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Ingredient> Ingredient { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Recipe> Recipe { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Identity needs this

            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new ChallengeSeed());
            builder.ApplyConfiguration(new CommentSeed());
            builder.ApplyConfiguration(new FavouriteSeed());
            builder.ApplyConfiguration(new IngredientSeed());
            builder.ApplyConfiguration(new RecipeSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
