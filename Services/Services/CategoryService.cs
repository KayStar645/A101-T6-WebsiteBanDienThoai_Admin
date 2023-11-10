using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Validators;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) 
        {
            _categoryRepo = categoryRepository;
            _mapper = mapper;
        }

        public async Task<(List<CategoryDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _categoryRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CategoryDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<CategoryDto> GetDetail(int pId)
        {
            var category = await _categoryRepo.GetDetailAsync(pId);

            var categoryDto = _mapper.Map<CategoryDto>(category);

            return categoryDto;
        }

        public async Task<bool> Create(CategoryDto pCreate)
        {
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

        public async Task<bool> Update(CategoryDto pUpdate)
        {
            CategoryValidator validator = new CategoryValidator(_categoryRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var category = _mapper.Map<Category>(pUpdate);

            var result = await _categoryRepo.UpdateAsync(category);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _categoryRepo.DeleteAsync(pId);

            return result;
        }
    }
}
