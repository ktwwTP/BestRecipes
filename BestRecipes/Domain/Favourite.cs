namespace BestRecipes.Domain
{
    public class Favourite : BaseDomainModel
    {
        public int UserId { get; set; } 
        public int RecipeId { get; set; } 
        public int CategoryId { get; set; } 
        public DateTime Date { get; set; }
    }
}
