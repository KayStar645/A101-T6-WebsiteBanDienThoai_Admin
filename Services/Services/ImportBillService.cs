using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using System.Transactions;

namespace Services.Services
{
    public class ImportBillService : IImportBillService
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

        public async Task<bool> Create(ImportBillDto pImportBill)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    bool flag = true;

                    var importBill = _mapper.Map<ImportBill>(pImportBill);
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
                    importBill.Price = sumPrice;
                    var update = await _importBillRepo.UpdateAsync(importBill);
                    if(update == false)
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

        public async Task<ImportBillDto> GetDetail(int pId)
        {
            var result = await _importBillRepo.GetDetailPropertiesAsync(pId);

            return result;
        }

        public async Task<(List<ImportBillDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pDistributorId = null)
        {
            var result = await _importBillRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pEmployeeId, pDistributorId);

            return result;
        }
    }
}
