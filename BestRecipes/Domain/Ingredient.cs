namespace BestRecipes.Domain
{
    public class Ingredient : BaseDomainModel
    {
        public string? Name { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public string? Category { get; set; }

        // Initialize the collection to prevent null reference errors
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}