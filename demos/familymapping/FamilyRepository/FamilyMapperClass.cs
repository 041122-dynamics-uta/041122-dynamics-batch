using System.Data.SqlClient;
using FamilyModels;

namespace FamilyRepository
{
    public class FamilyMapperClass
    {
        //create a method that will transfer the date from the members list return into members
        internal Customer DboToCustomer(SqlDataReader reader)
        {

            Customer m = new Customer((string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
            m.CustomerId = (int)reader[0];
            return m;
        }
    }
}