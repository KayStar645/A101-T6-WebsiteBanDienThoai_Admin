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
        public const string TYPE_RECEIVED = "R"; // Đã nhận hàng

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

        public static (string type, string typename)[] GetTypeMapping(string? pType = null)
        {
            var typesMapping = new[]
            {
                (TYPE_ORDER, "Đặt hàng"),
                (TYPE_APPROVE, "Đã xác nhận"),
                (TYPE_TRANSPORT, "Đang vận chuyển"),
                (TYPE_RECEIVED, "Đã nhận hàng"),
                (TYPE_CANNEL, "Hủy đơn hàng"),
            };

            if (pType != null)
            {
                var result = typesMapping.FirstOrDefault(item => item.Item1 == pType);

                return result != default ? new[] { result } : typesMapping;
            }

            return typesMapping;
        }
    }
}
