namespace BestRecipes.Domain
{

    public class Ingredient : BaseDomainModel
    {
        public string Name { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
