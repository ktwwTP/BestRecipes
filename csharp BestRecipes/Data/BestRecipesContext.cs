using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BestRecipes.Domain;
using BestRecipes.Configurations.Entities;

namespace BestRecipes.Data
{
    public class BestRecipesContext : IdentityDbContext<ApplicationUser>
    {
        public BestRecipesContext(DbContextOptions<BestRecipesContext> options)
           : base(options)
        {
        }

        public DbSet<BestRecipes.Domain.Category> Category { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Challenge> Challenge { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Comment> Comment { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Favourite> Favourite { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Ingredient> Ingredient { get; set; } = default!;
        public DbSet<BestRecipes.Domain.Recipe> Recipe { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new ChallengeSeed());
            builder.ApplyConfiguration(new CommentSeed());
            builder.ApplyConfiguration(new FavouriteSeed());
            builder.ApplyConfiguration(new IngredientSeed());
            builder.ApplyConfiguration(new RecipeSeed());
        }
    }
}