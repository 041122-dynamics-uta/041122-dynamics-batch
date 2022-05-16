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
