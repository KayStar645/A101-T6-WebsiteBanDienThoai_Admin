using Domain.Entities;

namespace Database.Interfaces
{
    public interface IDetailSpecificationsRepository : IBaseRepository<DetailSpecifications>
    {
        Task<List<DetailSpecifications>> GetBySpecificationsIdAsync(int pSpecificationsId);
    }
}
