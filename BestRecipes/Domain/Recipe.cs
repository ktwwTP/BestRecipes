namespace BestRecipes.Domain
{
    public class Recipe : BaseDomainModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int PreparationTime { get; set; }
        public int CookingDuration { get; set; }
        public int ServingSize { get; set; }
        public int IngredientId { get; set; }
        public int UserId { get; set; }   
        public int CategoryId { get; set; } 
    }
}
