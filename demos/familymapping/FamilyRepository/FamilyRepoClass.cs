using FamilyModels;
using System.Data.SqlClient;

namespace FamilyRepository;
public class FamilyRepoClass
{
    //inject the dependency into the class
    //private FamilyRepoClass _repo { get; set; }
    public FamilyMapperClass _mapper { get; set; }

    string connectionString = $"Server=tcp:adopractice-server-moore.database.windows.net,1433;Initial Catalog=adonetpractice_moore;Persist Security Info=False;User ID=adonetpractice;Password=Thisis1funnyhorse!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



    public FamilyRepoClass()
    {
        // this._repo = r;
        this._mapper = new FamilyMapperClass();
    }

    public List<Member> MembersList()
    {
        string myQuery1 = "SELECT * FROM _Members;";
        //this using block creates teh SqlConnection.
        // the SqlConnection is the object that communicates with the Db.
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Connection.Open();//open the connection to the Db
            SqlDataReader results = command.ExecuteReader();//actually conduct the query.

            //query the FamilyRepository Db for the list of members
            //USE ADO.NET .........
            //use the mapper to transfer the falues in to Member objects in a List<Member>.
            List<Member> ml = new List<Member>();
            while (results.Read())
            {
                ml.Add(this._mapper.DboToMember(results));//send in the row of the reader to be mapped.
            }

            query1.Close();
            return ml;
        }
    }
}
