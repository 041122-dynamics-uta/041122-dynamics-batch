using FamilyModels;
using FamilyRepository;

namespace FamilyBusiness;
public class FamilyBusinessClass
{
    //inject the dependency into the class
    private FamilyRepoClass _repo { get; set; }
    public FamilyBusinessClass(FamilyRepoClass r)
    {
        this._repo = r;
    }



    /// <summary>
    /// This method will:
    /// 1. See if a user by the given usernamd and password already exist. If so, will return 0
    /// 2. Will return the new Customer Object to the customer parameter.
    /// 3. If new customer insertion is unseccessful, will return -1.
    /// </summary>
    public async Task<int> RegisterCustomerAsync(string fname, string lname, string userName, string password, Customer newCustomer)
    {
        // pass the data to the repo layer methd that checks if that username/password combo exists.
        bool existsOrNah = await _repo.UnamePwordComboExistsAsync(userName, password);
        bool success;
        if (existsOrNah)
        {
            return 0;// customer usernaem and password already exists
        }
        else
        {
            success = await _repo.RegisterCustomerAsync(fname, lname, userName, password);
        }

        //check if the insertion was successful
        if (success)
        {
            //get the user back from the Db and return the customer.
            //Customer newCustomer1 = await _repo.GetCustomerByUnamePword(userName, password);
            //Console.WriteLine($"The new customer retirned form the Db is {newCustomer1.Fname}, {newCustomer1.Lname}");
            //newCustomer = newCustomer1;
            return 1;//make sure the save the new customer data to the Customer parameter
        }
        else return -1;
    }

    /// <summary>
    /// Customer can log in to the application with a username and password. 
    /// usethe username and password as login
    /// </summary>
    public async Task<Customer> CustomerLoginAsync(string username, string password)
    {
        return await _repo.GetCustomerByUnamePwordAsync(username, password);
    }

    /// <summary>
    /// View a list of stores 
    /// </summary>
    /// <returns></returns>
    public List<Store> StoreList()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// view available products to purchase at that store.// each store has its own product 
    /// need storeID and customerID
    /// </summary>
    /// <returns></returns>
    public List<Product> ProductsFromStore(Store StoreId)
    {
        throw new NotImplementedException();
    }

    //view their past purchases from a store. (Include date of purchase, Item ID, Item name, quantity, and total cost.) // an order should be linked to a store 
    public List<Order> OrdersFromStore(Store StoreId, Customer custId)
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// this method Dictionary of ProductId/quantity
    /// and a customer Id and StoreId
    /// </summary>
    /// <returns></returns>
    public void SubmitOrder()
    {
        throw new NotImplementedException();

    }








    //below is unrelated methods

    // public List<Member> MembersList()
    // {
    //     List<Member> ml = _repo.MembersList();
    //     return ml;
    // }

    // public Member NewMember(string fname, string lname, string age, string familyId)
    // {
    //     //pass the new data to the repo layer to insert int to the db.
    //     Member m = _repo.NewMember(fname, lname, age, familyId);
    //     return m;
    // }
}
