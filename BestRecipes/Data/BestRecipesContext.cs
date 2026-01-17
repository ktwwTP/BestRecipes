using BestRecipes.Configurations.Entities;
using BestRecipes.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BestRecipes.Data
{
    public class BestRecipesContext(DbContextOptions<BestRecipesContext> options) : IdentityDbContext<BestRecipesUser>(options)
    {
        // Core Tables
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Challenge> Challenge { get; set; } = default!;
        public DbSet<Comment> Comment { get; set; } = default!;
        public DbSet<Favourite> Favourite { get; set; } = default!;
        public DbSet<Ingredient> Ingredient { get; set; } = default!;
        public DbSet<Recipe> Recipe { get; set; } = default!;

        // Join Tables
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecipeIngredient>()
            .Property(p => p.Quantity)
            .HasColumnType("decimal(18,2)"); // 18 digits total, 2 after the decimal point

            // --- RELATIONSHIP CONFIGURATIONS ---

            // Many-to-Many: Recipe <-> Ingredient
            builder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);

            // --- DATA SEEDING ---

            // Identity Seeding
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

            // Domain Seeding
            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new IngredientSeed());
            builder.ApplyConfiguration(new RecipeSeed());
            builder.ApplyConfiguration(new RecipeIngredientSeed());
            builder.ApplyConfiguration(new ChallengeSeed());
            builder.ApplyConfiguration(new CommentSeed());
            builder.ApplyConfiguration(new FavouriteSeed());
        }
    }
}