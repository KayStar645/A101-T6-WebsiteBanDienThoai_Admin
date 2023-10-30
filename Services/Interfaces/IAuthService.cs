using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IAuthService
    {
        Task<int> CreateAccount(UserDto pUser);

        Task<bool> Login(UserDto pUser);

        void Logout();
    }
}
