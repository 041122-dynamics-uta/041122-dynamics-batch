namespace FamilyModels
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string ProductName, string Description, decimal Price)
        {
            this.ProductId = -1;
            this.ProductName = ProductName;
            this.Description = Description;
            this.Price = Price;
        }


    }
}