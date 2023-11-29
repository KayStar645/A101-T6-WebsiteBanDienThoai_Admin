using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IAuthService
    {
        Task<List<UserDto>> GetList();

        Task<UserDto> GetDetail(string pUserName);

        Task<int> CreateAccount(UserDto pUser);

        Task<bool> Login(UserDto pUser);

        void Logout();
    }
}
