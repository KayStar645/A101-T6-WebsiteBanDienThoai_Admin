using Domain.Entities;

namespace Database.Interfaces
{
    public interface IPromotionProductRepository : IBaseRepository<PromotionProduct>
    {
        Task<List<Product>> GetProductsByPromotionId(int pPromotionId);

        Task<bool> DeleteAsync(int pPromotionId, int pProductId);
    }
}
