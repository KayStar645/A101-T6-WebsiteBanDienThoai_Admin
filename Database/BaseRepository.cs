using System.Data;
using System.Reflection;

namespace Database
{
    public abstract class BaseRepository<T>
    {
        #region CONST AND STATIC

        public static int maxField = 30;

        #endregion


        #region PROPERTIES

        protected readonly DatabaseAccess _databaseAccess;

        protected abstract string _model { get; }

        protected abstract List<string> _fields { get; }

        protected abstract List<string> _seachers { get; }

        #endregion


        #region CONSTRUCTER

        public BaseRepository(DatabaseAccess databaseAccess)
        {
            _databaseAccess = databaseAccess;
        }

        #endregion


        #region FUNCTION

        public virtual DataTable Get(out int totalCount, List<string> pFields = null, string? pKeyword = "", int? pId = null,
            string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10)
        {
            // Lấy những cột nào
            List<string> fields = pFields == null ? _fields.ToList() : 
                                                    pFields.Intersect(_fields).ToList();

            // Điều kiện tuyệt đối
            List<string> filter = new List<string>();

            if (pId != null)
            {
                filter.Add($"id = {pId}");
            }
            filter.Add($"IsDeleted = 0");

            // Điều kiện tương đối
            List<string> searchs = new List<string>();

            if (pKeyword != "")
            {
                foreach (string item in _seachers)
                {
                    searchs.Add($"{item} like N'%{pKeyword}%'");
                }
            }
            string resultSearchs = searchs.Count() > 0 ? $" and ({string.Join(" or ", searchs)})" : "";

            // Truy vấn

            string query = $"select Id, {string.Join(", ", fields)} " +
                           $"from {_model} " +
                           $"where {string.Join(" and ", filter)} {resultSearchs} " +
                           $"order by {pSort} " +
                           $"offset {(pPageNumber - 1) * pPageSize} rows " +
                           $"fetch next {pPageSize} rows only";

            string subQuery = $"select count(Id) from {_model}";

            totalCount = int.Parse(_databaseAccess.ExecuteScalar(subQuery).ToString());

            return _databaseAccess.ExcuteQuery(query);
        }

        public virtual bool Add(T pModel)
        {
            Type type = pModel.GetType();

            PropertyInfo[] properties = type.GetProperties();

            // Thêm những cột nào
            List<string> fields = properties.Select(property => property.Name)
                                            .Intersect(_fields).ToList();

            List<string> value = new List<string>();
            foreach (string fieldName in fields)
            {
                PropertyInfo property = properties.FirstOrDefault(p => p.Name == fieldName);
                if (property != null)
                {
                    // Nếu kiểu date thì làm sao (chưa check)
                    value.Add($"N'{property.GetValue(pModel)}'");
                }
            }

            // Câu lệnh thêm dữ liệu
            string query = $"insert into {_model} ({string.Join(", ", fields)}, IsDeleted) " +
                                         $"values ({string.Join(", ", value)}, 0)";

            return _databaseAccess.InsertOrUpdate(query);
        }

        public virtual bool Update(T pModel)
        {
            Type type = pModel.GetType();

            PropertyInfo[] properties = type.GetProperties();

            // Sửa dòng nào
            string id = properties.FirstOrDefault(p => p.Name == "Id")
                                  .GetValue(pModel).ToString();

            // Sửa những cột nào
            List<string> fields = properties.Select(property => property.Name)
                                            .Intersect(_fields).ToList();

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
            string query = $"update {_model} " +
                           $"set {string.Join(", ", value)} " +
                           $"where Id = {id}";

            return _databaseAccess.InsertOrUpdate(query);
        }

        public virtual bool Delete(int id)
        {
            // Câu lệnh cập nhật trường IsDeleted
            string query = $"update {_model} " +
                           $"set IsDeleted = 1 " +
                           $"where Id = {id}";

            return _databaseAccess.InsertOrUpdate(query);
        }

        #endregion
    }
}
