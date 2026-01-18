namespace BestRecipes.Domain
{
    public class Recipe : BaseDomainModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public bool IsTrending { get; set; }
        public string Instructions { get; set; } = string.Empty;
        public int PreparationTime { get; set; }
        public int CookingDuration { get; set; }
        public int ServingSize { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        // Initialized as a new list
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}