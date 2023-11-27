using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Domain.DTOs.More;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class ImportBillRepository : BaseRepository<ImportBill>, IImportBillRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(ImportBill);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "ImportDate",
            "Price",
            "Type",
            "EmployeeId",
            "DistributorId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
        };

        #endregion

        #region CONSTRUCTER

        public ImportBillRepository() { }


        #endregion


        #region FUNCTION
        public async Task<(List<ImportBillDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(
                                        string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1,
                                        int? pPageSize = 10, int? pEmployeeId = null, int? pDistributorId = null)
        {
            try
            {
                List<string> filter = new List<string>();
                filter.Add($"IB.IsDeleted = 0");

                List<string> searchs = new List<string>();
                if (pKeyword != "")
                {
                    foreach (string item in _seachers)
                    {
                        searchs.Add($"IB.{item} like N'%{pKeyword}%'");
                    }
                }

                string whereEmployee = "";
                if (pEmployeeId != null)
                {
                    whereEmployee = $" and EmployeeId = {pEmployeeId} ";
                }

                string wherepDistributor = "";
                if (pDistributorId != null)
                {
                    wherepDistributor = $" and DistributorId = {pDistributorId} ";
                }

                string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

                string query = $"SELECT IB.Id, IB.InternalCode, IB.ImportDate, IB.Price, " +
                                      $"E.Id as EmployeeId, E.InternalCode as EmployeeInternalCode, E.Name as EmployeeName, " +
                                      $"D.Id as DistributorId, D.InternalCode as DistributorInternalCode, D.Name as DistributorName " +
                               $"FROM ImportBill AS IB " +
                               $"LEFT JOIN Employee AS E ON IB.EmployeeId = E.Id " +
                               $"LEFT JOIN Distributor AS D ON IB.DistributorId = D.Id " +
                               $"where {string.Join(" and ", filter)} {resultSearchs} {whereEmployee} {wherepDistributor}" +
                               $"order by {pSort} " +
                               $"offset {(pPageNumber - 1) * pPageSize} rows " +
                               $"fetch next {pPageSize} rows only";

                string subQuery = $"SELECT COUNT(Id) FROM {_model} as IB " +
                                  $"where {string.Join(" and ", filter)} {resultSearchs} {whereEmployee} {wherepDistributor};";
                int totalCount = await new SqlConnection(DatabaseCommon.ConnectionString)
                                        .ExecuteScalarAsync<int>(subQuery)
                                        .ConfigureAwait(false);

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryAsync<ImportBillDto>(query).ConfigureAwait(false);

                    decimal pageNumber = Math.Ceiling(totalCount / (decimal)pPageSize);

                    return (result.AsList(), totalCount, (int)pageNumber);
                }
            }
            catch (Exception ex)
            {
                return (default(List<ImportBillDto>), 0, 0);
            }
        }

        public async Task<ImportBillDto> GetDetailPropertiesAsync(int pId)
        {
            try
            {
                string query = $"SELECT IB.Id, IB.InternalCode, IB.ImportDate, IB.Price, " +
                                      $"E.Id as EmployeeId, E.InternalCode as EmployeeInternalCode, E.Name as EmployeeName, " +
                                      $"D.Id as DistributorId, D.InternalCode as DistributorInternalCode, D.Name as DistributorName " +
                               $"FROM ImportBill AS IB " +
                               $"LEFT JOIN Employee AS E ON IB.EmployeeId = E.Id " +
                               $"LEFT JOIN Distributor AS D ON IB.DistributorId = D.Id " +
                               $"where IB.Id = {pId} and IB.IsDeleted = 0";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var importBill = await connection.QueryFirstOrDefaultAsync<ImportBillDto>(query).ConfigureAwait(false);

                    if(importBill != null)
                    {
                        string queryDetail = $"SELECT DI.Id, DI.Quantity, DI.Price, DI.ProductId, " +
                                                $"P.InternalCode AS ProductInternalCode, P.Name AS ProductName, P.Images AS ProductImage, P.ColorId, P.CapacityId, " +
                                                $"Cl.InternalCode AS ColorInternalCode, Cl.Name AS ColorName, " +
                                                $"Cc.Name AS CapacityName " +
                                                $"FROM DetailImport AS DI " +
                                                $"LEFT JOIN Product AS P ON DI.ProductId = P.Id " +
                                                $"LEFT JOIN Color AS Cl ON CL.Id = P.ColorId " +
                                                $"LEFT JOIN Capacity AS Cc ON Cc.Id = P.CapacityId " +
                                             $"WHERE DI.ImportBillId = {pId} and DI.IsDeleted = 0";

                        importBill.Details = (List<DetailImportDto>?)await connection.QueryAsync<DetailImportDto>(queryDetail).ConfigureAwait(false);   
                    }

                    return importBill;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<string> RangeInternalCode()
        {
            var query = "SELECT InternalCode FROM [ImportBill]";
            IEnumerable<string> internalCodes = new List<string>();

            using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                internalCodes = await connection.QueryAsync<string>(query).ConfigureAwait(false);
            }

            int max = 0;
            foreach (var internalCode in internalCodes)
            {
                int number = int.Parse(internalCode.Substring(9));
                max = Math.Max(max, number);
            }
            max++;
            string code = max.ToString();
            while (code.Length < 7)
            {
                code = "0" + code;
            }
            DateTime currentDate = DateTime.Now;

            return "NH" + currentDate.ToString("yyMMdd") + "-" + code;
        }    
        #endregion
    }
}
