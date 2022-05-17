namespace FamilyModels
{
    public class Customer
    {
        public int CustomerId { get; set; }// Db will handle this
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        // public Customer()
        // {

        // }
    }
}