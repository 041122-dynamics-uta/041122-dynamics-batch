namespace FamilyModels
{
    public class Customer
    {
        public int CustomerId { get; set; }// Db will handle this
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Pass { get; set; }
        public string Username { get; set; }

        public Customer(string fname, string lname, string username, string password)
        {
            this.CustomerId = -1;
            this.Fname = fname;
            this.Lname = lname;
            this.Username = username;
            this.Pass = password;
        }
    }
}