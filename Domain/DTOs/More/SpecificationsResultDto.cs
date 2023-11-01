namespace Domain.DTOs.More
{
    public class SpecificationsResultDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DetailSpecificationsId { get; set; }
        public string? DetailSpecificationsName { get; set; }
        public string? DetailSpecificationsDescription { get; set; }
    }
}
