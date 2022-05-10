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
}
