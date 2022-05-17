namespace FamilyModels
{
    public class Inventory
    {
        public Dictionary<Product, int> Products { get; set; } = new Dictionary<Product, int>();
        public Store Store { get; set; } = new Store();
    }
}