using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ProductSpecifications : BaseEntity
    {
        public int? SpecificationsId { get; set; }
        public int? ProductId { get; set; }


        // Ràng buộc

        [ForeignKey("SpecificationsId")]
        public Specifications? Specifications { get; set; }


        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
