using FamilyModels;
using System.Data.SqlClient;

namespace FamilyRepository;
public class FamilyRepoClass
{
    //inject the dependency into the class
    public FamilyMapperClass _mapper { get; set; }
    string connectionString = $"Server=tcp:adopractice-server-moore.database.windows.net,1433;Initial Catalog=p1rebuild;Persist Security Info=False;User ID=adonetpractice;Password=Thisis1funnyhorse!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public FamilyRepoClass()
    {
        this._mapper = new FamilyMapperClass();
    }

    /// <summary>
    /// This method registers a new Customer and returns true if the operation is successful. 
    /// false, if not.
    /// </summary>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public async Task<bool> RegisterCustomerAsync(string fname, string lname, string userName, string password)
    {
        string query = $"INSERT INTO Customers (Fname, Lname, Username, Pass) VALUES (@f, @l, @u, @p);";
        //this using block creates teh SqlConnection.
        // the SqlConnection is the object that communicates with the Db.
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@f", fname);
            command.Parameters.AddWithValue("@l", lname);
            command.Parameters.AddWithValue("@u", userName);
            command.Parameters.AddWithValue("@p", password);
            await con.OpenAsync();//open the connection to the Db
            int results = await command.ExecuteNonQueryAsync();//actually conduct the query.
            await con.CloseAsync();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.

            if (results == 1)
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// The method will query the Db for a Customer by the Username and Password.
    /// Then map the DBO to a Customer.
    /// </summary>
    /// <returns></returns>
    public async Task<Customer> GetCustomerByUnamePwordAsync(string userName, string password)
    {
        string query = "SELECT * FROM Customers WHERE Username = @u AND Pass= @p;";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@u", userName);
            command.Parameters.AddWithValue("@p", password);
            await con.OpenAsync();//open the connection to the Db
            SqlDataReader results = await command.ExecuteReaderAsync();//actually conduct the query.

            if (results.Read())
            {
                Customer nc = _mapper.DboToCustomer(results);
                Console.WriteLine($"{nc.Fname} {nc.Lname}");
                await con.CloseAsync();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
                return nc;
            }
            else
            {
                await con.CloseAsync();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
                return null;
            }
        }
    }

    /// <summary>
    /// This method will query the Db to see if a username/password combination already exists.
    /// if yes, returns true 
    /// if no, returns false. 
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public async Task<bool> UnamePwordComboExistsAsync(string userName, string password)
    {
        // query the Db to see if this username/password combo alreqdy exists
        string query = "SELECT * FROM Customers WHERE Username = @u AND Pass = @p;";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@u", userName);
            command.Parameters.AddWithValue("@p", password);
            await con.OpenAsync();//open the connection to the Db
            SqlDataReader results = await command.ExecuteReaderAsync();//actually conduct the query.

            if (await results.ReadAsync())
            {
                await con.CloseAsync();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
                return true;
            }
            else
            {
                await con.CloseAsync();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
                return false;
            }
        }
    }

    // public Member NewMember(string fname, string lname, string age, string familyId)
    // {
    //     string myQuery1 = $"INSERT INTO _Members (Fname, lname, Age, Family) VALUES (@f, @l, @a, @fam);";
    //     //this 'using' block creates thh SqlConnection.
    //     // the SqlConnection is the object that communicates with the Db.
    //     using (SqlConnection query1 = new SqlConnection(connectionString))
    //     {
    //         //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
    //         SqlCommand command = new SqlCommand(myQuery1, query1);
    //         command.Parameters.AddWithValue("@f", fname);
    //         command.Parameters.AddWithValue("@l", lname);
    //         command.Parameters.AddWithValue("@a", age);
    //         command.Parameters.AddWithValue("@fam", 10);
    //         query1.Open();//open the connection to the Db
    //         int results = command.ExecuteNonQuery();//actually conduct the query.
    //         query1.Close();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.

    //         // I usually requery the Db to get the data fresh and triple verify that the data was inputted correctly

    //         if (results == 1)
    //         {
    //             Member m = new Member
    //             {
    //                 MemberIdId = 100,
    //                 Fname = fname,
    //                 lname = lname,
    //                 Age = Int32.Parse(age),
    //                 FamilyId = 2
    //             };
    //             return m;
    //         }
    //         return null;

    //     };
    // }

    // public List<Member> MembersList()
    // {
    //     string myQuery1 = "SELECT * FROM _Members;";
    //     //this using block creates teh SqlConnection.
    //     // the SqlConnection is the object that communicates with the Db.
    //     using (SqlConnection query1 = new SqlConnection(connectionString))
    //     {
    //         //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
    //         SqlCommand command = new SqlCommand(myQuery1, query1);
    //         command.Connection.Open();//open the connection to the Db
    //         SqlDataReader results = command.ExecuteReader();//actually conduct the query.

    //         //query the FamilyRepository Db for the list of members
    //         //USE ADO.NET .........
    //         //use the mapper to transfer the falues in to Member objects in a List<Member>.
    //         List<Member> ml = new List<Member>();
    //         while (results.Read())
    //         {
    //             //mapp the current table row to a Member class objects
    //             Member m = this._mapper.DboToMember(results);
    //             ml.Add(m);//send in the row of the reader to be mapped.
    //         }
    //         query1.Close();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
    //         return ml;
    //     }
    // }
}
