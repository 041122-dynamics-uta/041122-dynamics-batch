namespace FamilyModels
{
    public class Order
    {
        public Guid OrderId { get; set; } = new Guid();
        public Dictionary<Product, int> Products { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }


    }
}