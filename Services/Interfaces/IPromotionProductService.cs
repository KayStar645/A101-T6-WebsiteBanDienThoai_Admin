using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IPromotionProductService
    {
        Task<(List<PromotionProductDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<bool> Create(PromotionProductDto pCreate);

        Task<bool> Delete(int pId);
    }
}
