using Dapper;
using Database.Common;
using Database.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;

namespace Database.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region CONST AND STATIC

        public static int maxField = 30;

        #endregion


        #region PROPERTIES

        protected abstract string _model { get; }

        protected abstract List<string> _fields { get; }

        protected abstract List<string> _seachers { get; }

        #endregion


        #region CONSTRUCTER

        public BaseRepository() { }

        #endregion


        #region FUNCTION

        public virtual async Task<(List<T> list, int totalCount)> GetAllAsync(List<string> pFields = null, string? pKeyword = "",
                                            string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10)
        {
            // Lấy những cột nào
            List<string> fields = pFields == null ? _fields.ToList() :
                                                    pFields.Intersect(_fields).ToList();

            List<string> filter = new List<string>();
            filter.Add($"IsDeleted = 0");

            List<string> searchs = new List<string>();
            if (pKeyword != "")
            {
                foreach (string item in _seachers)
                {
                    searchs.Add($"{item} like N'%{pKeyword}%'");
                }
            }
            string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

            string query = $"SELECT Id, {string.Join(", ", fields)} " +
                           $"FROM {_model} " +
                           $"WHERE {string.Join(" AND ", filter)} {resultSearchs} " +
                           $"ORDER BY {pSort} " +
                           $"LIMIT {pPageSize} " +
                           $"OFFSET {(pPageNumber - 1) * pPageSize};";

            string subQuery = $"SELECT COUNT(Id) FROM {_model};";
            int totalCount = await new MySqlConnection(DatabaseCommon.ConnectionString)
                                    .ExecuteScalarAsync<int>(subQuery)
                                    .ConfigureAwait(false);

            using (var connection = new MySqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connection.QueryAsync<T>(query).ConfigureAwait(false);
                return (result.AsList(), totalCount);
            }
        }


        public virtual async Task<T> GetDetailAsync(int pId, List<string> pFields = null)
        {
            try
            {
                // Lấy những cột nào
                List<string> fields = pFields == null ? _fields.ToList() :
                                                        pFields.Intersect(_fields).ToList();

                string query = $"SELECT Id, {string.Join(", ", fields)} " +
                               $"FROM {_model} " +
                               $"WHERE id = {pId}";
                using (var connection = new MySqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryFirstOrDefaultAsync<T>(query).ConfigureAwait(false);
                    return result;
                }
            }
            catch
            {
                return default(T);
            }
        }




        public virtual async Task<bool> AddAsync(T pModel)
        {
            try
            {
                Type type = pModel.GetType();
                PropertyInfo[] properties = type.GetProperties();

                List<string> fields = properties
                    .Where(property => property.Name != "Id")
                    .Select(property => property.Name)
                    .Intersect(_fields)
                    .ToList();

                List<string> values = new List<string>();
                foreach (string fieldName in fields)
                {
                    PropertyInfo property = properties.FirstOrDefault(p => p.Name == fieldName);
                    if (property != null)
                    {
                        values.Add($"N'{property.GetValue(pModel)}'");
                    }
                }

                // Câu lệnh thêm dữ liệu
                string query = $"INSERT INTO {_model} ({string.Join(", ", fields)}, IsDeleted) " +
                               $"VALUES ({string.Join(", ", values)}, 0);";
                string subQuery = "SELECT LAST_INSERT_ID();";

                using (var connection = new MySqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryFirstOrDefaultAsync<T>(query).ConfigureAwait(false);

                    var insertedId = await connection.ExecuteScalarAsync<int>(subQuery).ConfigureAwait(false);
                    return insertedId > 0;
                }                
            }
            catch { return false; }
        }



        public virtual async Task<bool> UpdateAsync(T pModel)
        {
            try
            {
                Type type = pModel.GetType();
                PropertyInfo[] properties = type.GetProperties();

                string id = properties.FirstOrDefault(p => p.Name == "Id")?.GetValue(pModel)?.ToString();

                if (id != null)
                {
                    List<string> fields = properties
                        .Where(property => property.Name != "Id")
                        .Select(property => property.Name)
                        .Intersect(_fields)
                        .ToList();

                    List<string> value = new List<string>();
                    foreach (string fieldName in fields)
                    {
                        PropertyInfo property = properties.FirstOrDefault(p => p.Name == fieldName);

                        if (property.Name != null)
                        {
                            value.Add($"{fieldName} = N'{property.GetValue(pModel)}'");
                        }
                    }

                    // Câu lệnh cập nhật dữ liệu
                    string query = $"UPDATE {_model} " +
                                   $"SET {string.Join(", ", value)} " +
                                   $"WHERE Id = @Id";

                    using (var connection = new MySqlConnection(DatabaseCommon.ConnectionString))
                    {
                        var rowsAffected = await connection.ExecuteAsync(query, new { Id = id, pModel }).ConfigureAwait(false);
                        return rowsAffected > 0;
                    }
                }

                return false;
            }
            catch { return false; }
        }


        public virtual async Task<bool> DeleteAsync(int pId)
        {
            try
            {
                string query = $"UPDATE {_model} " +
                           $"SET IsDeleted = 1 " +
                           $"WHERE Id = @Id";

                using (var connection = new MySqlConnection(DatabaseCommon.ConnectionString))
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
