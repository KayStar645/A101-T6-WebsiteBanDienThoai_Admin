using Database;
using WinFormsApp.Entities;
using WinFormsApp.Models;

namespace WinFormsApp.Repositories
{
    public class EmployeeRepository : BaseRepository<EmployeeModel>
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Employee);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Sex",
            "Birthday",
            "Phone"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Sex",
            "Birthday",
            "Phone"
        };

        #endregion

        #region CONSTRUCTER

        public EmployeeRepository(DatabaseAccess databaseAccess) : base(databaseAccess)
        {
        }

        #endregion


        #region FUNCTION


        #endregion


    }
}
