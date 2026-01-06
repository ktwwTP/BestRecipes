namespace BestRecipes.Domain
{
    public class Challenge : BaseDomainModel
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
