namespace FamilyModels
{
    public class OriginClass
    {
        public int OriginId { get; set; }
        public string? OriginName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}