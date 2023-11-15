using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs.More;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class PromotionProductRepository : BaseRepository<PromotionProduct>, IPromotionProductRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(PromotionProduct);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "ProductId",
            "PromotionId",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "ProductId",
            "PromotionId",
        };

        protected override List<string> _filter { get; } = new List<string>()
        {
            "ProductId",
            "PromotionId",
        };

        #endregion

        #region CONSTRUCTER

        public PromotionProductRepository() { }


        #endregion


        #region FUNCTION

        public async Task<List<ProductPropertiesDto>> GetProductsByPromotionId(int pPromotionId)
        {
            string query = $"select P.Id, P.InternalCode, P.Name, P.Price, P.Quantity, P.Images, " +
                                    $"P.CategoryId, Cg.InternalCode as CategoryInternalCode, Cg.Name as CategoryName, " +
                                    $"P.ColorId, Cl.InternalCode as ColorInternalCode, Cl.Name as ColorName, " +
                                    $"P.CapacityId, Cc.Name as CapacityName " +
                           $"from Product as P " +
                           $"left join Capacity as Cc on P.CapacityId = Cc.Id " +
                           $"left join Category as Cg on P.CategoryId = Cg.Id " +
                           $"left join Color as Cl on P.ColorId = Cl.Id " +
                           $"LEFT JOIN PromotionProduct AS PP ON P.Id = PP.ProductId " +
                           $"WHERE P.IsDeleted = 0 AND PP.PromotionId = {pPromotionId}";

            using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connection.QueryAsync<ProductPropertiesDto>(query).ConfigureAwait(false);

                return result.AsList();
            }
        }    
        public override async Task<bool> DeleteAsync(int pId)
        {
            try
            {
                string query = $"DELETE {_model} " +
                           $"WHERE Id = @Id";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var parameters = new { Id = pId };
                    var rowsAffected = await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);

                    return rowsAffected > 0;
                }
            }
            catch { return false; }
        }

        public async Task<bool> DeleteAsync(int pPromotionId, int pProductId)
        {
            try
            {
                string query = $"DELETE {_model} " +
                           $"WHERE promotionId = @PromotionId and productId = @ProductId";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var parameters = new { PromotionId = pPromotionId, ProductId = pProductId };
                    var rowsAffected = await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);

                    return rowsAffected > 0;
                }
            }
            catch { return false; }
        }

        #endregion
    }
}
