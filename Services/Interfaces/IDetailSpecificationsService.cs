using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IDetailSpecificationsService
    {
        Task<(List<DetailSpecificationsDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<DetailSpecificationsDto> GetDetail(int pId);

        Task<bool> Create(DetailSpecificationsDto pCreate);

        Task<bool> Update(DetailSpecificationsDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
