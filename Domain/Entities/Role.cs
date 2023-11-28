using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Role : BaseEntity
    {
        public string? Name { get; set; }

        [NotMapped]
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        [NotMapped]
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
