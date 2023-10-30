using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

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

        public async Task<(List<CategoryDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _categoryRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CategoryDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<CategoryDto> GetDetail(int pId)
        {
            var category = await _categoryRepo.GetDetailAsync(pId);

            var CategoryDto = _mapper.Map<CategoryDto>(category);

            return CategoryDto;
        }

        public async Task<bool> Create(CategoryDto pCreatecategory)
        {
            var category = _mapper.Map<Category>(pCreatecategory);

            var result = await _categoryRepo.AddAsync(category);

            return result;
        }

        public async Task<bool> Update(CategoryDto pUpdatecategory)
        {
            var category = _mapper.Map<Category>(pUpdatecategory);

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
