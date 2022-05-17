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
    /// A customer should be able to resister 
    /// get all the info for registration: fname, lname, username, password, 
    /// </summary>
    public void RegisterCustomer()
    {
    }

    /// <summary>
    /// Customer can log in to the application with a username and password. 
    /// usethe username and password as login
    /// </summary>
    public void CustomerLogin()
    {

    }

    /// <summary>
    /// View a list of stores 
    /// </summary>
    /// <returns></returns>
    //public List<Store> StoreList()
    // {

    // }

    /// <summary>
    /// view available products to purchase at that store.// each store has its own product 
    /// need storeID and customerID
    /// </summary>
    /// <returns></returns>
    // public List<Products> ProductsFromStore(Store StoreId)
    // {

    // }

    //view their past purchases from a store. (Include date of purchase, Item ID, Item name, quantity, and total cost.) // an order should be linked to a store 
    // public List<Order> OrdersFromStore(Store StoreId, Customer custId)
    // {

    // }

    /// <summary>
    /// this method Dictionary of ProductId/quantity
    /// and a customer Id and StoreId
    /// </summary>
    /// <returns></returns>
    public void SubmitOrder()
    {

    }








    //below is unrelated methods

    public List<Member> MembersList()
    {
        List<Member> ml = _repo.MembersList();
        return ml;
    }

    public Member NewMember(string fname, string lname, string age, string familyId)
    {
        //pass the new data to the repo layer to insert int to the db.
        Member m = _repo.NewMember(fname, lname, age, familyId);
        return m;
    }
}
