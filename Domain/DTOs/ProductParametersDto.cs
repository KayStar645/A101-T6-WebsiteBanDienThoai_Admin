namespace Domain.DTOs
{
    public class ProductParametersDto
    {
        public int Id { get; set; }

        public int? DetailSpecificationsId { get; set; }
        public int? ProductId { get; set; }
    }
}
