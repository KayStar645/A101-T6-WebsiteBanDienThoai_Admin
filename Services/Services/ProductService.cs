using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.DTOs.More;
using Domain.Entities;
using Domain.ModelViews;
using Services.Interfaces;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepo = productRepository;
            _mapper = mapper;
        }

        public async Task<(List<ProductVM> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pCategoryId = null)
        {
            var result = await _productRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pCategoryId);

            var list = _mapper.Map<List<ProductVM>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<DetailProductPropertiesDto> GetDetail(int pId)
        {
            var detailProduct = await _productRepo.GetDetailPropertiesAsync(pId);

            return detailProduct;
        }

        public async Task<int> Create(ProductDto pCreate)
        {
            Product product = _mapper.Map<Product>(pCreate);

            var result = await _productRepo.AddAsync(product);

            return result;
        }

        public async Task<bool> Update(ProductDto pCreate)
        {
            Product product = _mapper.Map<Product>(pCreate);

            var result = await _productRepo.UpdateAsync(product);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _productRepo.DeleteAsync(pId);

            return result;
        }
    }
}
