using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDto> GetDetail(int pId);

        Task<(List<OrderDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pCustomerId = null);

        Task<bool> ChangeTypeOrder(int pOrderId, string pType);

        Task<bool> Create(OrderDto pOrder);

        Task<bool> Update(OrderDto pOrder);
    }
}
