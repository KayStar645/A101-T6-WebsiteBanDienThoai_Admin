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

        public virtual DataTable Get(List<string> pFields = null, string? pKeyword = "", int? pId = null)
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
            string query = $"select {string.Join(", ", fields)} " +
                           $"from {_model} " +
                           $"where {string.Join(" and ", filter)}" + resultSearchs;

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
                    value.Add($"N'{property.GetValue(pModel).ToString()}'");
                }
            }

            fields.Add("IsDeleted");
            value.Add("0");
            // Câu lệnh thêm dữ liệu
            string query = $"insert into {_model} ({string.Join(", ", fields)}) " +
                                         $"values ({string.Join(", ", value)})";

            return _databaseAccess.Insert(query);
        }

        #endregion
    }
}
