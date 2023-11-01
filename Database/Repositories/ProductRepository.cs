using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Product);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Images",
            "Price",
            "CategoryId",
            "ColorId",
            "CapacityId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Price",
            "CategoryId",
            "ColorId",
            "CapacityId"
        };

        protected override List<string> _ranges { get; } = new List<string>()
        {
            "Price"
        };

        //protected override List<string> _join { get; } = new List<string>()
        //{
        //    "Capacity:Name",
        //    "Category:InternalCode,Name",
        //    "Color:InternalCode,Name",
        //    //"ProductParameters.DetailSpecifications:Name,Description",
        //    //"ProductParameters.DetailSpecifications.Specifications:Name",
        //};


        #endregion

        #region CONSTRUCTER

        public ProductRepository() { }

        #endregion


        #region FUNCTION

        public async Task<(List<ProductPropertiesDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(List<string> pFields = null, string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10)
        {
            try
            {
                List<string> filter = new List<string>();
                filter.Add($"P.IsDeleted = 0");

                List<string> searchs = new List<string>();
                if (pKeyword != "")
                {
                    foreach (string item in _seachers)
                    {
                        searchs.Add($"{item} like N'%{pKeyword}%'");
                    }
                }
                string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

                string query = $"select P.Id, P.InternalCode, P.Name, P.Price, P.Quantity, P.Images, " +
                                      $"P.CategoryId, Cg.InternalCode as CategoryInternalCode, Cg.Name as CategoryName, " +
                                      $"P.ColorId, Cl.InternalCode as ColorInternalCode, Cl.Name as ColorName, " +
                                      $"P.CapacityId, Cc.Name as CapacityName " +
                               $"from Product as P " +
                               $"left join Capacity as Cc on P.CapacityId = Cc.Id " +
                               $"left join Category as Cg on P.CategoryId = Cg.Id " +
                               $"left join Color as Cl on P.ColorId = Cl.Id " +
                               $"where {string.Join(" and ", filter)} {resultSearchs} " +
                               $"order by {pSort} " +
                               $"offset {(pPageNumber - 1) * pPageSize} rows " +
                               $"fetch next {pPageSize} rows only";

                string subQuery = $"SELECT COUNT(Id) FROM {_model} as P where {string.Join(" and ", filter)} {resultSearchs};";
                int totalCount = await new SqlConnection(DatabaseCommon.ConnectionString)
                                        .ExecuteScalarAsync<int>(subQuery)
                                        .ConfigureAwait(false);

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryAsync<ProductPropertiesDto>(query).ConfigureAwait(false);

                    decimal pageNumber = Math.Ceiling((decimal)totalCount / (decimal)pPageSize);

                    return (result.AsList(), totalCount, (int)pageNumber);
                }
            }    
            catch (Exception ex)
            {
                return (null, 0, 0);
            }
        }

        #endregion
    }
}
