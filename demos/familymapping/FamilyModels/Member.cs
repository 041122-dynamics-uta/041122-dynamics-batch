using System;

namespace FamilyModels;
public class Member
{
    //public Guid MemberIdId { get; set; } = new Guid();
    public int MemberIdId { get; set; } = -1;
    public string Fname { get; set; } = "";
    public string lname { get; set; } = "";
    public int Age { get; set; } = 0;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public FamilyClass Family { get; set; } = null;

}
