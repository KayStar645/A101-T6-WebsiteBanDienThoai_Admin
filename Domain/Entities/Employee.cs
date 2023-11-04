using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public string? Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public string? Phone { get; set; }

        public int? UserId { get; set; }

        // Ràng buộc
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
