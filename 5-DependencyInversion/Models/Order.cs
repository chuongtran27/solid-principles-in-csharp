namespace SolidPrinciples.DependencyInversion.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string[] Items { get; set; }
        public long TotalAmount { get; set; }
    }
}