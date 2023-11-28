using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string? Name { get; set; }

        [NotMapped]
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
