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

    public Member NewMember(string fname, string lname, string age, string familyId)
    {
        string myQuery1 = $"INSERT INTO _Members (Fname, lname, Age, Family) VALUES (@f, @l, @a, @fam);";
        //this using block creates teh SqlConnection.
        // the SqlConnection is the object that communicates with the Db.
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Parameters.AddWithValue("@f", fname);
            command.Parameters.AddWithValue("@l", lname);
            command.Parameters.AddWithValue("@a", age);
            command.Parameters.AddWithValue("@fam", 10);
            query1.Open();//open the connection to the Db
            int results = command.ExecuteNonQuery();//actually conduct the query.
            query1.Close();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.

            // I usually requery the Db to get the data fresh and triple verify that the data was inputted correctly

            if (results == 1)
            {
                Member m = new Member
                {
                    MemberIdId = 100,
                    Fname = fname,
                    lname = lname,
                    Age = Int32.Parse(age),
                    FamilyId = 2
                };
                return m;
            }
            return null;

        };
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
                //mapp the current table row to a Member class objects
                Member m = this._mapper.DboToMember(results);
                ml.Add(m);//send in the row of the reader to be mapped.
            }

            query1.Close();//YOU MUST CLOSE THE CONNECTION FOR ANY OTHER METHOD TO ACCESS THE DB.
            return ml;
        }
    }
}
