using System.Data.SqlClient;
using FamilyModels;

namespace FamilyRepository
{
    public class FamilyMapperClass
    {
        //create a method that will transfer the date from the members list return into members
        internal Member DboToMember(SqlDataReader reader)
        {
            Member m = new Member
            {
                MemberIdId = (int)reader[0],
                Fname = (string)reader[1],
                lname = (string)reader[2],
                Age = (byte)reader[3],
                DateCreated = (DateTime)reader[4],
                FamilyId = (int)reader[5],
            };
            return m;
        }
    }
}