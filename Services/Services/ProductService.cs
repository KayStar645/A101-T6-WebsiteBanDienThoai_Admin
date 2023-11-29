using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Domain.Identities;
using Domain.ModelViews;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Validators;

namespace Services.Services
{
    public class ProductService : IProductService, IService
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepo;
        private readonly ICapacityRepository _capacityRepo;

        public ProductService(IProductRepository productRepository, IMapper mapper,
            IColorRepository colorRepository, ICapacityRepository capacity)
        {
            _productRepo = productRepository;
            _mapper = mapper;
            _colorRepo = colorRepository;
            _capacityRepo = capacity;
        }

        [RequirePermission("Product.View")]
        public async Task<(List<ProductVM> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pCategoryId = null)
        {
            var result = await _productRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pCategoryId);

            var list = _mapper.Map<List<ProductVM>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Product.View")]
        public async Task<DetailProductVM> GetDetail(int pId)
        {
            var detailProduct = await _productRepo.GetDetailPropertiesAsync(pId);

            var mapDetail = _mapper.Map<DetailProductVM>(detailProduct);

            return mapDetail;
        }

        [RequirePermission("Product.Create")]
        public async Task<int> Create(ProductDto pCreate)
        {
            ProductValidator validator = new ProductValidator(_productRepo, _colorRepo, _capacityRepo);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            if (pCreate.CapacityId == 0)
            {
                pCreate.CapacityId = null;
            }

            Product product = _mapper.Map<Product>(pCreate);

            var result = await _productRepo.AddAsync(product);

            return result;
        }

        [RequirePermission("Product.Update")]
        public async Task<bool> Update(ProductDto pUpdate)
        {
            ProductValidator validator = new ProductValidator(_productRepo, _colorRepo, _capacityRepo, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            if (pUpdate.CapacityId == 0)
            {
                pUpdate.CapacityId = null;
            }

            Product product = _mapper.Map<Product>(pUpdate);

            var result = await _productRepo.UpdateAsync(product);

            return result > 0;
        }

        [RequirePermission("Product.Delete")]
        public async Task<bool> Delete(int pId)
        {
            var result = await _productRepo.DeleteAsync(pId);

            return result;
        }
    }
}
