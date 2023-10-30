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

        public async Task<(List<ColorDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _colorRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<ColorDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<ColorDto> GetDetail(int pId)
        {
            var color = await _colorRepo.GetDetailAsync(pId);

            var ColorDto = _mapper.Map<ColorDto>(color);

            return ColorDto;
        }

        public async Task<bool> Create(ColorDto pCreatecolor)
        {
            var color = _mapper.Map<Domain.Entities.Color>(pCreatecolor);

            var result = await _colorRepo.AddAsync(color);

            return result;
        }

        public async Task<bool> Update(ColorDto pUpdatecolor)
        {
            var color = _mapper.Map<Domain.Entities.Color>(pUpdatecolor);

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
