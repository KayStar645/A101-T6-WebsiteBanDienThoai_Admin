using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IDetailSpecificationsService
    {
        Task<List<DetailSpecificationsDto>> GetListBySpecificationsIdAsync(int pSpecificationsId);

        Task<bool> Create(DetailSpecificationsDto pCreate);

        Task<bool> Update(DetailSpecificationsDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
