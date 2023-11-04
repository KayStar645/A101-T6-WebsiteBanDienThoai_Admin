namespace Domain.DTOs
{
    public class ImportBillDto
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public DateTime ImportDate { get; set; }

        public long Price { get; set; }

        public string? Type { get; set; }

        public int? EmployeeId { get; set; }

        public string? EmployeeInternalCode { get; set; }

        public string? EmployeeName { get; set; }

        public int? DistributorId { get; set; }

        public string? DistributorInternalCode { get; set; }

        public string? DistributorName { get; set; }

        public List<DetailImportDto>? Details { get; set; }
    }
}
