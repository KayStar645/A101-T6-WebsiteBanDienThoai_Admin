using Domain.Entities;
using Domain.ModelViews;

namespace Services.Interfaces
{
    public interface IRoleService
    {
        Task<List<Role>> GetList();
        Task<RoleVM> GetDetail(int pId);
        Task<RoleVM> Create(RoleVM pCreate);
        Task<RoleVM> Update(RoleVM pCreate);

        Task<RoleVM> AssignRoles(AssignRoleVM pRequest);
        Task<RoleVM> RevokeRole(AssignRoleVM pRequest);

    }
}
