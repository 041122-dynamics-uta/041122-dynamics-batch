using FamilyModels;

namespace FamilyRepository;
public class FamilyRepoClass
{
    //inject the dependency into the class
    //private FamilyRepoClass _repo { get; set; }
    public FamilyMapperClass _mapper { get; set; }
    public FamilyRepoClass()
    {
        // this._repo = r;
        this._mapper = new FamilyMapperClass();
    }



    public List<Member> MembersList()
    {
        //query the FamilyRepository Db for the list of members
        //USE ADO.NET .........
        //use the mapper to transfer the falues in to Member objects in a List<Member>.
        List<Member> ml = new List<Member>();
        while (Reader.Read())
        {
            ml.Add(this._mapper.DboToMember(reader));//send in the row of the reader to be mapped.
        }

        return ml;
    }
}
