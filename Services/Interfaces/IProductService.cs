﻿using Domain.DTOs;
using Domain.DTOs.More;
using Domain.ModelViews;

namespace Services.Interfaces
{
    public interface IProductService
    {
        Task<(List<ProductVM> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pCategoryId = null);

        Task<DetailProductVM> GetDetail(int pId);

        Task<int> Create(ProductDto pCreate);

        Task<bool> Update(ProductDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
