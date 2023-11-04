using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DetailImport : BaseEntity
    {
        public int? Quantity { get; set; }

        public long? Price { get; set; }

        public int? ProductId { get; set; }

        public int? ImportBillId { get; set; }


        // Ràng buộc
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("ImportBillId")]
        public ImportBill? ImportBill { get; set; }


    }
}
