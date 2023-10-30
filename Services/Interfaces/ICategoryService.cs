using Domain.DTOs;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        Task<(List<CategoryDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<CategoryDto> GetDetail(int pId);

        Task<bool> Create(CategoryDto pCreate);

        Task<bool> Update(CategoryDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
