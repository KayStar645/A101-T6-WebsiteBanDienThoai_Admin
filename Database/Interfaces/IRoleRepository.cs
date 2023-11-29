using Domain.Entities;
using System.Threading.Tasks;

namespace Database.Interfaces
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<int> AssignRoles(UserRole userRole);

        Task<int> RevokeRole(UserRole userRole);

        Task DeleteRolePer(int pRoleId, string pPer);

        Task AddRolePer(int pRoleId, string pPer);
    }
}
