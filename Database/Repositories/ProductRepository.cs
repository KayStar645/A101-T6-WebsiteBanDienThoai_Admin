using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Domain.DTOs.More;
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

        public async Task<(List<ProductPropertiesDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(
                                        string? pKeyword = "", string? pSort = "Id", 
                                        int? pPageNumber = 1, int? pPageSize = 10, int? pCategoryId = null)
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

                string whereCategory = "";
                if(pCategoryId != null)
                {
                    whereCategory = $" and CategoryId = {pCategoryId} ";
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
                               $"where {string.Join(" and ", filter)} {resultSearchs} {whereCategory}" +
                               $"order by {pSort} " +
                               $"offset {(pPageNumber - 1) * pPageSize} rows " +
                               $"fetch next {pPageSize} rows only";

                string subQuery = $"SELECT COUNT(Id) FROM {_model} as P " +
                                  $"where {string.Join(" and ", filter)} {resultSearchs} {whereCategory};";
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

        public async Task<DetailProductPropertiesDto> GetDetailPropertiesAsync(int pId)
        {
            try
            {
                string query = $"select P.Id, P.InternalCode, P.Name, P.Price, P.Quantity, P.Images, " +
                                      $"P.CategoryId, Cg.InternalCode as CategoryInternalCode, Cg.Name as CategoryName, " +
                                      $"P.ColorId, Cl.InternalCode as ColorInternalCode, Cl.Name as ColorName, " +
                                      $"P.CapacityId, Cc.Name as CapacityName " +
                               $"from Product as P " +
                               $"left join Capacity as Cc on P.CapacityId = Cc.Id " +
                               $"left join Category as Cg on P.CategoryId = Cg.Id " +
                               $"left join Color as Cl on P.ColorId = Cl.Id " +
                               $"where P.Id = {pId} and P.IsDeleted = 0";


                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    DetailProductPropertiesDto detailProduct = await connection.QueryFirstOrDefaultAsync<DetailProductPropertiesDto>(query).ConfigureAwait(false);

                    if(detailProduct != null)
                    {
                        // Lấy ds kỹ thuật
                        string querySpecifications = $"SELECT S.Id, S.Name, " +
                                                       $"DS.Id as DetailSpecificationsId, DS.Name as DetailSpecificationsName, " +
                                                       $"DS.Description as DetailSpecificationsDescription " +
                                                     $"FROM Specifications as S " +
                                                     $"LEFT JOIN DetailSpecifications as DS on DS.SpecificationsId = S.Id " +
                                                     $"LEFT JOIN ProductParameters as PP on PP.DetailSpecificationsId = DS.Id " +
                                                     $"LEFT JOIN Product as P on P.Id = PP.ProductId " +
                                                     $"WHERE P.Id = {pId}";

                        var specifications = await connection.QueryAsync<SpecificationsResultDto>(querySpecifications).ConfigureAwait(false);

                        List<SpecificationsDto> specificationsDtos = new List<SpecificationsDto>();

                        SpecificationsDto specificationsDto = new SpecificationsDto();

                        int tempId = 0;
                        foreach (var item in specifications)
                        {
                            if(tempId != item.Id)
                            {
                                if(tempId != 0)
                                {
                                    specificationsDtos.Add(specificationsDto);
                                }
                                specificationsDto = new SpecificationsDto()
                                {
                                    Id = item.Id,
                                    Name = item.Name,
                                    Details = new List<DetailSpecificationsDto>()
                                };
                                tempId = item.Id;
                            }
                            specificationsDto.Details.Add(new DetailSpecificationsDto
                            {
                                Id = item.DetailSpecificationsId,
                                Name = item.DetailSpecificationsName,
                                Description = item.DetailSpecificationsDescription
                            });
                        }

                        if(specifications.Count() > 0)
                        {
                            specificationsDtos.Add(specificationsDto);
                        }    

                        detailProduct.SpecificationsDtos = specificationsDtos;
                    }

                    return detailProduct;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> IncreasingNumberAsync(int pProductId, int pNumber)
        {
            try
            {
                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    string query = $"UPDATE Product SET Quantity = ISNULL(Quantity, 0) + {pNumber} WHERE Id = {pProductId}";

                    await connection.ExecuteAsync(query).ConfigureAwait(false);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
