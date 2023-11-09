using Dapper;
using Database.Common;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
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

        // Chưa làm được
        // Số, thời gian
        // Cận trên, cận dưới
        // "column:min:max"
        protected virtual List<string> _ranges { get; }

        // Chưa làm được: join với các bảng khác
        // 1. Thuộc tính tham chiếu ở model hiện tại
        // 2. Thuộc tính tham chiếu ở model muốn join tới
        protected virtual List<string> _join { get; }

        #endregion


        #region CONSTRUCTER

        public BaseRepository() { }

        #endregion


        #region FUNCTION

        public virtual async Task<(List<T> list, int totalCount, int pageNumber)> GetAllAsync(List<string> pFields = null, string? pKeyword = "",
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

            string query = $"select Id, {string.Join(", ", fields)} " +
                           $"from {_model} " +
                           $"where {string.Join(" and ", filter)} {resultSearchs} " +
                           $"order by {pSort} " +
                           $"offset {(pPageNumber - 1) * pPageSize} rows " +
                           $"fetch next {pPageSize} rows only";

            string subQuery = $"SELECT COUNT(Id) FROM {_model} where {string.Join(" and ", filter)} {resultSearchs};";
            int totalCount = await new SqlConnection(DatabaseCommon.ConnectionString)
                                    .ExecuteScalarAsync<int>(subQuery)
                                    .ConfigureAwait(false);

            using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connection.QueryAsync<T>(query).ConfigureAwait(false);

                decimal pageNumber = Math.Ceiling((decimal)totalCount / (decimal)pPageSize);

                return (result.AsList(), totalCount, (int)pageNumber);
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
                               $"FROM \"{_model}\" " +
                               $"WHERE id = {pId} and IsDeleted = 0";
                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
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


        public virtual async Task<int> AddAsync(T pModel)
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
                string query = $"INSERT INTO \"{_model}\" ({string.Join(", ", fields)}, IsDeleted) " +
                               $"OUTPUT INSERTED.Id VALUES ({string.Join(", ", values)}, 0);";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var insertedId = await connection.ExecuteScalarAsync<int>(query, null).ConfigureAwait(false);
                    return insertedId;
                }                
            }
            catch { return 0; }
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

                        if (property.GetValue(pModel) != null)
                        {
                            value.Add($"{fieldName} = N'{property.GetValue(pModel)}'");
                        }
                    }

                    // Câu lệnh cập nhật dữ liệu
                    string query = $"UPDATE {_model} " +
                                   $"SET {string.Join(", ", value)} " +
                                   $"WHERE Id = @Id";

                    using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
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

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var parameters = new { Id = pId };
                    var rowsAffected = await connection.ExecuteAsync(query, parameters).ConfigureAwait(false);

                    return rowsAffected > 0;
                }
            }
            catch { return false; }
        }

        public virtual async Task<bool> AnyInternalCodeAsync(string pInternalCode, int? pId = null)
        {
            try
            {
                var query = $"SELECT COUNT(Id) " +
                            $"FROM \"{_model}\" " +
                            $"WHERE IsDeleted = 0 and InternalCode = N'{pInternalCode}'";
                if(pId != null)
                {
                    query += $" and Id != {pId}";
                }    

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var count = await connection.ExecuteScalarAsync<int>(query).ConfigureAwait(false);

                    return count > 0;
                }
            }
            catch { return false; }
        }

        public virtual async Task<bool> AnyIdAsync<Entity>(int pId)
        {
            try
            {
                var query = $"SELECT COUNT(Id) " +
                            $"FROM \"{typeof(Entity)}\" " +
                            $"WHERE IsDeleted = 0 and Id = N'{pId}'";

                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var count = await connection.ExecuteScalarAsync<int>(query).ConfigureAwait(false);

                    return count > 0;
                }
            }
            catch { return false; }
        }


        // Không sài được: rối qué
        public virtual async Task<(List<ModelVM> list, int totalCount, int pageNumber)> GetAllJoinAsync<ModelVM>(
                                                List<string> pFields = null, string? pKeyword = "",
                                                string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10)
        {
            List<string> joinTables = new List<string>();

            List<string> fields = pFields == null ? _fields.ToList() :
                                                pFields.Intersect(_fields).ToList();

            List<string> originalTableFields = fields.Select(f => $"{_model}.{f}").ToList();

            List<string> joinedTableFields = new List<string>();
            List<string> joinConditions = new List<string>();

            foreach (var join in _join)
            {
                var joinParts = join.Split(':');
                joinTables.Add(joinParts[0]);
                var joinFields = joinParts[1].Split(',');

                joinedTableFields.AddRange(joinFields);
                joinConditions.Add($"{_model}.Id = {joinParts[0]}.{_model}Id");
            }

            // Lấy các trường từ bảng gốc và các trường từ các bảng join
            List<string> allFields = originalTableFields.Concat(joinedTableFields.Select(f => $"{joinTables[0]}.{f}")).ToList();

            List<string> filter = new List<string>();
            filter.Add($"{_model}.IsDeleted = 0");

            List<string> searchs = new List<string>();
            if (!string.IsNullOrEmpty(pKeyword))
            {
                foreach (string item in _seachers)
                {
                    searchs.Add($"{item} like N'%{pKeyword}%'");
                }
            }
            string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

            // Tạo câu truy vấn SQL với JOIN
            string joinClauses = string.Join(" ", joinTables.Zip(joinConditions, (joinTable, condition) =>
                $"left join {joinTable} on {condition}"));

            string query = $"select {_model}.Id, {string.Join(", ", allFields)} " +
                           $"from {_model} {joinClauses} " +
                           $"where {string.Join(" and ", filter)} {resultSearchs} " +
                           $"order by {_model}.{pSort} " +
                           $"offset {(pPageNumber - 1) * pPageSize} rows " +
                           $"fetch next {pPageSize} rows only";

            string subQuery = $"SELECT COUNT({_model}.Id) FROM {_model} {joinClauses} " +
                             $"where {string.Join(" and ", filter)} {resultSearchs};";

            int totalCount = await new SqlConnection(DatabaseCommon.ConnectionString)
                                    .ExecuteScalarAsync<int>(subQuery)
                                    .ConfigureAwait(false);

            using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connection.QueryAsync<ModelVM>(query).ConfigureAwait(false);

                decimal pageNumber = Math.Ceiling((decimal)totalCount / (decimal)pPageSize);

                return (result.AsList(), totalCount, (int)pageNumber);
            }
        }


        #endregion
    }
}


/* Test Transaction

using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
{
    await connection.OpenAsync().ConfigureAwait(false);

    using (var transaction = connection.BeginTransaction())
    {
        try
        {
            // Thực hiện câu lệnh INSERT với OUTPUT clause và lấy giá trị ID
            var insertedId = await connection.ExecuteScalarAsync<int>(query, null, transaction).ConfigureAwait(false);

            transaction.Commit(); // Thực hiện commit transaction nếu thành công
            return insertedId > 0;
        }
        catch (Exception)
        {
            transaction.Rollback(); // Rollback transaction nếu xảy ra lỗi
            throw; // Rethrow exception để xử lý ở lớp gọi
        }
    }
}

 
 */
