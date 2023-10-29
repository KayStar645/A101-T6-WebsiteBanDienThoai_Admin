namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string? InternalCode { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Phone { get; set; }
    }
}
