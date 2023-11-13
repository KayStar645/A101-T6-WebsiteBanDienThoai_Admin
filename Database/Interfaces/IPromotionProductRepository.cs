using Domain.Entities;

namespace Database.Interfaces
{
    public interface IPromotionProductRepository : IBaseRepository<PromotionProduct>
    {
        Task<bool> DeleteAsync(int pPromotionId, int pProductId);
    }
}
