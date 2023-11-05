using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    // Có thời gian thì tách đơn hàng tới bến
    public class ImportBill : BaseEntity
    {
        [NotMapped]
        public const string TYPE_DRAFT = "D"; // Nháp

        [NotMapped]
        public const string TYPE_ORDER = "O"; // Đã đặt hàng

        [NotMapped]
        public const string TYPE_ENTERED = "E"; // Đã nhận hàng (đã nhập)


        public string? InternalCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ImportDate { get; set; }

        public long? Price { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? Type {  get; set; }

        public int? EmployeeId { get; set; }

        public int? DistributorId { get; set; }


        // Ràng buộc
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }

        [ForeignKey("DistributorId")]
        public Distributor? Distributor { get; set; }
    }
}
