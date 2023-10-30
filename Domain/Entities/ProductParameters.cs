using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ProductParameters : BaseEntity
    {
        public int? DetailSpecificationsId { get; set; }
        public int? ProductId { get; set; }


        // Ràng buộc

        [ForeignKey("DetailSpecificationsId")]
        public DetailSpecifications? DetailSpecifications { get; set; }


        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
