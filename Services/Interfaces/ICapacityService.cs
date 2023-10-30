using Domain.DTOs;

namespace Services.Interfaces
{
    public interface ICapacityService
    {
        Task<(List<CapacityDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<CapacityDto> GetDetail(int pId);

        Task<bool> Create(CapacityDto pCreate);

        Task<bool> Update(CapacityDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
