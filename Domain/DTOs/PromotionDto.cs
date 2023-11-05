namespace Domain.DTOs
{
    public class PromotionDto
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public long? PriceMin { get; set; }

        public long? Discount { get; set; }

        public long? Percent { get; set; }

        public string? Status { get; set; }
    }
}
