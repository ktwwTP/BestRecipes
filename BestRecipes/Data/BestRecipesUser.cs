using Microsoft.AspNetCore.Identity;

namespace BestRecipes.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BestRecipesUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

