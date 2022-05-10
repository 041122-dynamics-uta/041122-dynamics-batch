namespace FamilyModels
{
    public class FamilyClass
    {
        public int FamilyId { get; set; }
        public string? FamilyName { get; set; }
        public OriginClass? Origin { get; set; }
        public int OriginId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}