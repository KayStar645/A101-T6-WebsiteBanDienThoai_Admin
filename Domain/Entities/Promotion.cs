using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Promotion : BaseEntity
    {
        [NotMapped]
        public const string TYPE_DISCOUNT = "D";

        [NotMapped]
        public const string TYPE_PERCENT = "P";

        [NotMapped]
        public const string STATUS_DRAFT = "D";

        [NotMapped]
        public const string STATUS_APPROVED = "A";

        [NotMapped]
        public const string STATUS_CANCEL = "C";


        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [DefaultValue(0)]
        public long? PriceMin { get; set; }

        public long? Discount { get; set; }

        public long? Percent { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [DefaultValue(TYPE_PERCENT)]
        public string? Type { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [DefaultValue(TYPE_PERCENT)]
        public string? Status { get; set; }

        public (string Key, string Value)[] GetStatusMapping(string? pStatus = null)
        {
            var statusMapping = new[]
            {
                (STATUS_DRAFT, "Nháp"),
                (STATUS_APPROVED, "Đã duyệt"),
                (STATUS_CANCEL, "Hủy bỏ")
            };

            if (pStatus != null)
            {
                var result = statusMapping.FirstOrDefault(item => item.Item1 == pStatus);

                return result != default ? new[] { result } : statusMapping;
            }

            return statusMapping;
        }

        public (string Key, string Value)[] GetTypeMapping(string? pType = null)
        {
            var typeMapping = new[]
            {
                (TYPE_DISCOUNT, "Giảm giá"),
                (TYPE_PERCENT, "Giảm phần trăm"),
            };

            if (pType != null)
            {
                var result = typeMapping.FirstOrDefault(item => item.Item1 == pType);

                return result != default ? new[] { result } : typeMapping;
            }

            return typeMapping;
        }


    }
}
