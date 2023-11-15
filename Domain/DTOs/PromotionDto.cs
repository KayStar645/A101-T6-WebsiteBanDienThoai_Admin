using Domain.DTOs.More;
using Domain.ModelViews;

namespace Domain.DTOs
{
    public class PromotionDto
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public long? PercentMax { get; set; }

        public long? Discount { get; set; }

        public long? Percent { get; set; }

        public long? DiscountMax { get; set; }

        public string? Type { get; set; }

        public string? Status { get; set; }

        public List<ProductVM>? Products { get; set; }
    }
}
