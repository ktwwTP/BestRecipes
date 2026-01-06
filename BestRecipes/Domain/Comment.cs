namespace BestRecipes.Domain
{
    public class Comment : BaseDomainModel
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }  
        public int RecipeId { get; set; } 
    }
}
