namespace Database.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<(List<T> list, int totalCount, int pageNumber)> GetAllAsync(List<string> pFields = null, string? pKeyword = "",
                                            string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10);

        Task<T> GetDetailAsync(int pId, List<string> pFields = null);

        Task<int> AddAsync(T pModel);

        Task<bool> UpdateAsync(T pModel);

        Task<bool> DeleteAsync(int pId);
    }
}
