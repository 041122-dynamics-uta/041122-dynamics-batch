namespace FamilyModels
{
    public class Order
    {
        //maybe you want a lineItem prop?
        public Guid OrderId { get; set; } = new Guid();
        public Dictionary<Product, int> Products { get; set; }
        //public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }

        public Order(Dictionary<Product, int> products, Customer customer, Store store)
        {
            Products = products;
            Customer = customer;
            Store = store;
        }

    }
}