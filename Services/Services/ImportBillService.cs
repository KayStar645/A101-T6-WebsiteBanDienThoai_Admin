using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using System.Transactions;

namespace Services.Services
{
    public class ImportBillService : IImportBillService, IService
    {
        private readonly IImportBillRepository _importBillRepo;
        private readonly IMapper _mapper;
        private readonly IDetailImportRepository _detailImportRepo;
        private readonly IProductRepository _productRepo;

        public ImportBillService(IImportBillRepository importBillRepo, IMapper mapper, 
            IDetailImportRepository detailImportRepo, IProductRepository productRepo)
        {
            _importBillRepo = importBillRepo;
            _mapper = mapper;
            _detailImportRepo = detailImportRepo;
            _productRepo = productRepo;
        }

        public async Task<string> RangeInternalCode()
        {
            return await _importBillRepo.RangeInternalCode();
        }

        [RequirePermission("ImportBill.Create")]
        public async Task<bool> Create(ImportBillDto pImportBill)
        {
            if (CustomMiddleware.CheckPermission("ImportBill.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            using (var transaction = new TransactionScope())
            {
                try
                {
                    bool flag = true;

                    var importBill = _mapper.Map<ImportBill>(pImportBill);
                    importBill.Type = ImportBill.TYPE_ENTERED;
                    var resultImport = await _importBillRepo.AddAsync(importBill);

                    long? sumPrice = 0;

                    if(resultImport > 0)
                    {
                        foreach (var detailImport in pImportBill.Details)
                        {
                            sumPrice += (detailImport.Quantity * detailImport.Price);

                            detailImport.ImportBillId = resultImport;
                            var detail = _mapper.Map<DetailImport>(detailImport);

                            var resultDetail = await _detailImportRepo.AddAsync(detail);

                            if(resultDetail > 0)
                            {
                                var resultProduct = await _productRepo
                                    .IncreasingNumberAsync((int)detailImport.ProductId, (int)detailImport.Quantity);

                                if(resultProduct == false)
                                {
                                    flag = false;
                                    break;
                                }    
                            }
                            else
                            {
                                flag = false;
                                break;
                            }    
                        }    
                    }
                    else
                    {
                        flag = false;
                    }
                    importBill.Id = resultImport;
                    importBill.Price = sumPrice;
                    var update = await _importBillRepo.UpdateAsync(importBill);
                    if(update == 0)
                    {
                        flag = false;
                    }    



                    if ( flag ) { transaction.Complete(); }   
                    else { transaction.Dispose(); }

                    return flag;
                }
                catch (Exception)
                {
                    transaction.Dispose();
                    return false;
                }
            }
        }

        [RequirePermission("ImportBill.View")]
        public async Task<ImportBillDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("ImportBill.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _importBillRepo.GetDetailPropertiesAsync(pId);

            return result;
        }

        [RequirePermission("ImportBill.View")]
        public async Task<(List<ImportBillDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pDistributorId = null)
        {
            if (CustomMiddleware.CheckPermission("ImportBill.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _importBillRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pEmployeeId, pDistributorId);

            return result;
        }
    }
}
