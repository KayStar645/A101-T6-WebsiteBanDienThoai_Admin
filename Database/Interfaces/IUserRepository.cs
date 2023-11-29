using Domain.Entities;

namespace Database.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindByNameAsync(string pUserName);
        Task<List<string>> GetPermissionsByUserAsync(string pUserName);
    }
}
