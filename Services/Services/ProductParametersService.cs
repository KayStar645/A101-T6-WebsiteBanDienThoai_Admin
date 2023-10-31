using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class ProductParametersService : IProductParametersService
    {

        private readonly IProductParametersRepository _productParametersRepo;
        private readonly IMapper _mapper;

        public ProductParametersService(IProductParametersRepository productParametersRepository, IMapper mapper)
        {
            _productParametersRepo = productParametersRepository;
            _mapper = mapper;
        }

        public async Task<(List<ProductParametersDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _productParametersRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<ProductParametersDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<bool> Create(ProductParametersDto pCreate)
        {
            ProductParameters productParameters = _mapper.Map<ProductParameters>(pCreate);

            var result = await _productParametersRepo.AddAsync(productParameters);

            return result > 0;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _productParametersRepo.DeleteAsync(pId);

            return result;
        }
    }
}
