using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PromotionProduct : BaseEntity
    {
        public int ProductId { get; set; }

        public int PromotionId { get; set; }


        // Ràng buộc
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("PromotionId")]
        public Promotion? Promotion { get; set; }
    }
}
