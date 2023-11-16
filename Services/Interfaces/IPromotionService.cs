using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IPromotionService
    {
        Task<(List<PromotionDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<PromotionDto> GetDetail(int pId);

        Task<int> Create(PromotionDto pCreate);

        Task<bool> Update(PromotionDto pUpdate);

        Task<bool> Delete(int pId);

        Task<bool> Approve(int pId, string type);

        Task<bool> ApplyForProduct(int pId, List<int> pProductsId);
    }
}
