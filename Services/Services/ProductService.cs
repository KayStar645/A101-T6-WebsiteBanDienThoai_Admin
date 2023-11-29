using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Domain.ModelViews;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Interfaces.GoogleDrive;
using Services.Middleware;
using Services.Transform;
using Services.Validators;

namespace Services.Services
{
    public class ProductService : IProductService, IService
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;
        private readonly IColorRepository _colorRepo;
        private readonly ICapacityRepository _capacityRepo;
        private readonly IGoogleDriveService _googleDriveService;

        public ProductService(IProductRepository productRepository, IMapper mapper,
            IColorRepository colorRepository, ICapacityRepository capacity, IGoogleDriveService googleDriveService)
        {
            _productRepo = productRepository;
            _mapper = mapper;
            _colorRepo = colorRepository;
            _capacityRepo = capacity;
            _googleDriveService = googleDriveService;
        }

        [RequirePermission("Product.View")]
        public async Task<(List<ProductVM> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pCategoryId = null)
        {
            if (CustomMiddleware.CheckPermission("Product.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _productRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pCategoryId);

            var list = _mapper.Map<List<ProductVM>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Product.View")]
        public async Task<DetailProductVM> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Product.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var detailProduct = await _productRepo.GetDetailPropertiesAsync(pId);

            var mapDetail = _mapper.Map<DetailProductVM>(detailProduct);

            return mapDetail;
        }

        [RequirePermission("Product.Create")]
        public async Task<int> Create(ProductDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Product.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
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

            // Lưu hình ảnh trước nè
            var images = new List<string>();
            foreach(var image in pCreate.Images)
            {
                var url = await _googleDriveService.UploadFilesToGoogleDrive(new UploadVM
                {
                    FilePath = image,
                    FileName = $"products/{pCreate.Id}-{pCreate.Name}/{Guid.NewGuid()}"
                });
                images.Add(url);
            }

            pCreate.Images = images;
            Product product = _mapper.Map<Product>(pCreate);

            var result = await _productRepo.AddAsync(product);

            return result;
        }

        [RequirePermission("Product.Update")]
        public async Task<bool> Update(ProductDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Product.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
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
            // Lưu hình ảnh trước nè
            var images = new List<string>();
            foreach (var image in pUpdate.Images)
            {
                var url = await _googleDriveService.UploadFilesToGoogleDrive(new UploadVM
                {
                    FilePath = image,
                    FileName = $"products/{pUpdate.Id}-{pUpdate.Name}/{Guid.NewGuid()}"
                });
                images.Add(url);
            }

            Product product = _mapper.Map<Product>(pUpdate);

            var result = await _productRepo.UpdateAsync(product);

            return result > 0;
        }

        [RequirePermission("Product.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Product.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _productRepo.DeleteAsync(pId);

            return result;
        }
    }
}
