namespace Domain.DTOs
{
    public class DetailImportDto
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public long? Price { get; set; }

        public int? ProductId { get; set; }

        public int? ImportBillId { get; set; }
    }
}
