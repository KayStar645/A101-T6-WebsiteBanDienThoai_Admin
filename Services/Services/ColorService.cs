﻿using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;

namespace Services.Services
{
    public class ColorService : IColorService, IService
    {
        private readonly IColorRepository _colorRepo;
        private readonly IMapper _mapper;

        public ColorService(IColorRepository colorRepository, IMapper mapper) 
        {
            _colorRepo = colorRepository;
            _mapper = mapper;
        }

        [RequirePermission("Configuration.View")]
        public async Task<(List<ColorDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission("Configuration.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _colorRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<ColorDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Configuration.View")]
        public async Task<ColorDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Configuration.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var color = await _colorRepo.GetDetailAsync(pId);

            var ColorDto = _mapper.Map<ColorDto>(color);

            return ColorDto;
        }

        [RequirePermission("Configuration.Create")]
        public async Task<bool> Create(ColorDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Configuration.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            ColorValidator validator = new ColorValidator(_colorRepo);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var color = _mapper.Map<Domain.Entities.Color>(pCreate);

            var result = await _colorRepo.AddAsync(color);

            return result > 0;
        }

        [RequirePermission("Configuration.Update")]
        public async Task<bool> Update(ColorDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Configuration.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            ColorValidator validator = new ColorValidator(_colorRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var color = _mapper.Map<Domain.Entities.Color>(pUpdate);

            var result = await _colorRepo.UpdateAsync(color);

            return result > 0;
        }

        [RequirePermission("Configuration.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Configuration.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _colorRepo.DeleteAsync(pId);

            return result;
        }
    }
}
