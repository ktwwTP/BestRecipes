namespace BestRecipes.Domain
{
    public class RecipeIngredient : BaseDomainModel
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public decimal Quantity { get; set; }
        public string? Notes { get; set; } // e.g., "chopped", "diced"
    }
}