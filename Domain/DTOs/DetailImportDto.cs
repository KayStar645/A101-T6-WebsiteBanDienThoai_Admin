﻿namespace Domain.DTOs
{
    public class DetailImportDto
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public long? Price { get; set; }

        public int? ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? ProductInternalCode { get; set; }

        public string? ProductImage { get; set; }

        public int? ImportBillId { get; set; }

        public int ColorId { get; set; }

        public string? ColorInternalCode { get; set; }

        public string? ColorName { get; set; }

        public int CapacityId { get; set; }

        public string? CapacityName { get; set; }
    }
}
