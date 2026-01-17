namespace BestRecipes.Domain
{
    public class RecipeIngredient : BaseDomainModel
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = default!;

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = default!;

        public decimal Quantity { get; set; } // Matches your decimal type
        public string? Notes { get; set; }
        public string? Unit { get; set; }     // Already exists - great!
    }
}