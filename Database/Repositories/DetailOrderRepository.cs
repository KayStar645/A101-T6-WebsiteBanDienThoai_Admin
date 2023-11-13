using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class DetailOrderRepository : BaseRepository<DetailOrder>, IDetailOrderRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(DetailOrder);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "Quantity",
            "Price",
            "DiscountPrice",
            "SumPrice",
            "ProductId",
            "CustomerId",
            "OrderId",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "Quantity",
            "Price",
            "ProductId",
            "CustomerId",
            "OrderId",
        };

        #endregion

        #region CONSTRUCTER

        public DetailOrderRepository() { }


        #endregion


        #region FUNCTION
        public override async Task<bool> DeleteAsync(int pId)
        {
            try
            {
                string query = $"DELETE FROM \"{_model}\" " +
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
