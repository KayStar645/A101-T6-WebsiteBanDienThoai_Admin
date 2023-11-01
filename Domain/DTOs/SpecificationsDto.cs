namespace Domain.DTOs
{
    public class SpecificationsDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<DetailSpecificationsDto>? Details { get; set; }
    }
}
