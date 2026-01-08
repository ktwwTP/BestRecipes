using BestRecipes.Data;
using Microsoft.AspNetCore.Identity;

namespace BestRecipes.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<BestRecipesUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<BestRecipesUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
