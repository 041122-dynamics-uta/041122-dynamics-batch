using FamilyModels;

namespace FamilyRepository
{
    public class FamilyMapperClass
    {


        //create a method that will transfer the date from the members list return into members
        internal Member DboToMember(/*readerobject*/)
        {
            Member m = new Member
            {
                MemberIdId = reader[0],
                Fname = reader[1],
                lname = reader[2],
                Age = reader[3],
                DateCreated = reader[4],
                Family = reader[5]
            };
            return m;
        }
    }
}