using Domain.DTOs.More;
using Domain.Entities;

namespace Database.Interfaces
{
    public interface IPromotionProductRepository : IBaseRepository<PromotionProduct>
    {
        Task<List<ProductPropertiesDto>> GetProductsByPromotionId(int pPromotionId);

        Task<bool> DeleteAsync(int pPromotionId, int pProductId);
    }
}
