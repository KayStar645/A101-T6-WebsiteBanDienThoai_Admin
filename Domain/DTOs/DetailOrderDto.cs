namespace Domain.DTOs
{
    public class DetailOrderDto
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public long? DiscountPrice { get; set; }

        public long? Price { get; set; }

        public long? SumPrice { get; set; }

        public int? ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? ProductInternalCode { get; set; }

        public string? ProductImage { get; set; }

        public int? OrderId { get; set; }
    }
}
