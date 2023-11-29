using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;

namespace Services.Services
{
    public class CategoryService : ICategoryService, IService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) 
        {
            _categoryRepo = categoryRepository;
            _mapper = mapper;
        }

        [RequirePermission("Category.View")]
        public async Task<(List<CategoryDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission("Category.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _categoryRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CategoryDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Category.View")]
        public async Task<CategoryDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Category.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var category = await _categoryRepo.GetDetailAsync(pId);

            var categoryDto = _mapper.Map<CategoryDto>(category);

            return categoryDto;
        }

        [RequirePermission("Category.Create")]
        public async Task<bool> Create(CategoryDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Category.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            CategoryValidator validator = new CategoryValidator(_categoryRepo);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var category = _mapper.Map<Category>(pCreate);

            var result = await _categoryRepo.AddAsync(category);

            return result > 0;
        }

        [RequirePermission("Category.Update")]
        public async Task<bool> Update(CategoryDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Category.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            CategoryValidator validator = new CategoryValidator(_categoryRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var category = _mapper.Map<Category>(pUpdate);

            var result = await _categoryRepo.UpdateAsync(category);

            return result > 0;
        }

        [RequirePermission("Category.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Category.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _categoryRepo.DeleteAsync(pId);

            return result;
        }
    }
}
