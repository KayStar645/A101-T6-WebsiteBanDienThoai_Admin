using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DetailOrder : BaseEntity
    {
        public int? Quantity { get; set; }

        public long? DiscountPrice { get; set; }

        public long? Price { get; set; }

        public long? SumPrice { get; set; }

        public int? ProductId { get; set; }

        public int? OrderId { get; set; }


        // Ràng buộc
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
    }
}
