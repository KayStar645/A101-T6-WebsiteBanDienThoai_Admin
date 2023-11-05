using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public DateTime? OrderDate { get; set; }

        public long? Price { get; set; }

        public string? Type { get; set; }

        public int? EmployeeId { get; set; }

        public string? EmployeeInternalCode { get; set; }

        public string? EmployeeName { get; set; }

        public int? CustomerId { get; set; }

        public string? CustomerPhone { get; set; }

        public string? CustomerName { get; set; }

        public List<DetailOrderDto>? Details { get; set; }
    }
}
