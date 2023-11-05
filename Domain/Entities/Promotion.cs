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
    }
}
