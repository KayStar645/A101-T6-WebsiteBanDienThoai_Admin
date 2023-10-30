using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IColorService
    {
        Task<(List<ColorDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<ColorDto> GetDetail(int pId);

        Task<bool> Create(ColorDto pCreate);

        Task<bool> Update(ColorDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
