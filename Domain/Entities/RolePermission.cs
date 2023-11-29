using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class RolePermission : BaseEntity
    {
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }

        public int PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public Permission? Permission { get; set; }
    }
}
