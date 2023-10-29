using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
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

        public EmployeeRepository() { }

        #endregion


        #region FUNCTION


        #endregion


    }
}
