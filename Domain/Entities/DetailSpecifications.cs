using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DetailSpecifications : BaseEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? SpecificationsId { get; set; }

        // Ràng buộc

        [ForeignKey("SpecificationsId")]
        public Specifications? Specifications { get; set; }
    }
}
