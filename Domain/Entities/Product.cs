using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public string? Evaluate { get; set; }   // Làm sau, có thể thay đổi

        public string? Images { get; set; }

        [DefaultValue(0)]
        public int? Quantity { get; set; }

        [DefaultValue(0)]
        public long? Price { get; set; }

        public int? CategoryId { get; set; }

        public int? ColorId { get; set; }

        public int? CapacityId { get; set; }



        // Ràng buộc
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }


        [ForeignKey("ColorId")]
        public Color? Color { get; set; }


        [ForeignKey("CapacityId")]
        public Capacity? Capacity { get; set; }
    }
}
