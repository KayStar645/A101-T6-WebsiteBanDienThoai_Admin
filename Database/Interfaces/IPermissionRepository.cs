using Domain.Entities;

namespace Database.Interfaces
{
    public interface IPermissionRepository : IBaseRepository<Permission>
    {
        Task<List<string>> FindByName(string pName);

        Task<List<string>> GetByRoleId(int pRoleId);
    }
}
