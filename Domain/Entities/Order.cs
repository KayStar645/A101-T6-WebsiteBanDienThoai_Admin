using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        [NotMapped]
        public const string TYPE_ORDER = "O"; // Đặt hàng

        [NotMapped]
        public const string TYPE_APPROVE = "A"; // Xác nhận đơn hàng

        [NotMapped]
        public const string TYPE_TRANSPORT = "T"; // Đang vận chuyển

        [NotMapped]
        public const string TYPE_ENTERED = "E"; // Đã nhận hàng

        [NotMapped]
        public const string TYPE_CANNEL = "C"; // Hủy đơn hàng

        public string? InternalCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [DefaultValue(0)]
        public long? DiscountPrice { get; set; }

        [DefaultValue(0)]
        public long? Price { get; set; }

        [DefaultValue(0)]
        public long? SumPrice { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        public string? Type { get; set; }

        public int? EmployeeId { get; set; }

        public int? CustomerId { get; set; }


        // Ràng buộc
        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
    }
}
