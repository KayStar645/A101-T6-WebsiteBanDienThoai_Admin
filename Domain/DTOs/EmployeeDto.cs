namespace Domain.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public string? Sex { get; set; }

        public DateTime? Birthday { get; set; }

        public string? Phone { get; set; }

        public int? UserId { get; set; }
    }
}
