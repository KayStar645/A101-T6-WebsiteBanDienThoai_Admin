using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;
using System.Reflection;

namespace Database.Repositories
{
    public class PromotionRepository : BaseRepository<Promotion>, IPromotionRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Promotion);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Start",
            "End",
            "PriceMin",
            "Status",
            "Discount",
            "DiscountMax",
            "Percent",
            "PercentMax"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "PriceMin",
            "Status",
            "Discount",
            "DiscountMax",
            "Percent",
            "PercentMax"
        };

        #endregion

        #region CONSTRUCTER

        public PromotionRepository() { }


        #endregion


        #region FUNCTION

        public async override Task<bool> UpdateAsync(Promotion pModel)
        {
            _fields.Remove("Status");
            return await base.UpdateAsync(pModel);
        }

        public async Task<bool> ApproveAsync(int pId, string type)
        {
            try
            {
                // Câu lệnh cập nhật dữ liệu
                string query = $"UPDATE {_model} " +
                               "SET status = @Type " +
                               "WHERE Id = @Id";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var parameters = new { Id = pId, Type = type };
                    var rowsAffected = await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);
                    return rowsAffected > 0;
                }
            }
            catch { return false; }
        }

        #endregion
    }
}
