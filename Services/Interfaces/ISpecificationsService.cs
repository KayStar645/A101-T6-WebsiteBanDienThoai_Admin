using Domain.DTOs;

namespace Services.Interfaces
{
    public interface ISpecificationsService
    {
        Task<(List<SpecificationsDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<SpecificationsDto> GetDetail(int pId);

        Task<bool> Create(SpecificationsDto pCreate);

        Task<bool> Update(SpecificationsDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
