using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IPromotionService
    {
        Task<(List<PromotionDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<PromotionDto> GetDetail(int pId);

        Task<bool> Create(PromotionDto pCreate);

        Task<bool> Update(PromotionDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
