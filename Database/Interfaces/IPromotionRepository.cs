using Domain.Entities;

namespace Database.Interfaces
{
    public interface IPromotionRepository : IBaseRepository<Promotion>
    {
        Task<bool> ApproveAsync(int pId, string type);

        Task<List<Promotion>> GetByProductId(int productId);
    }
}
