using Domain.Entities;

namespace Database.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindByNameAsync(string pUserName);
    }
}
