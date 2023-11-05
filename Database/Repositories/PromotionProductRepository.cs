using Dapper;
using Database.Common;
using Database.Interfaces;
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

        #endregion

        #region CONSTRUCTER

        public PromotionProductRepository() { }


        #endregion


        #region FUNCTION
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

        #endregion
    }
}
