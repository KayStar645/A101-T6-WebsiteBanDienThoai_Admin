using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Services.Interfaces;

namespace Services.Services
{
    public class ColorService : IColorService
    {
        private readonly IColorRepository _colorRepo;
        private readonly IMapper _mapper;

        public ColorService(IColorRepository colorRepository, IMapper mapper) 
        {
            _colorRepo = colorRepository;
            _mapper = mapper;
        }

        public async Task<(List<ColorDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _colorRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<ColorDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<ColorDto> GetDetail(int pId)
        {
            var color = await _colorRepo.GetDetailAsync(pId);

            var ColorDto = _mapper.Map<ColorDto>(color);

            return ColorDto;
        }

        public async Task<bool> Create(ColorDto pCreate)
        {
            var color = _mapper.Map<Domain.Entities.Color>(pCreate);

            var result = await _colorRepo.AddAsync(color);

            return result > 0;
        }

        public async Task<bool> Update(ColorDto pCreate)
        {
            var color = _mapper.Map<Domain.Entities.Color>(pCreate);

            var result = await _colorRepo.UpdateAsync(color);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _colorRepo.DeleteAsync(pId);

            return result;
        }
    }
}
