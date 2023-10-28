using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Customer);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Phone",
            "Name",
            "Address",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Phone",
            "Name",
            "Address",
        };

        #endregion

        #region CONSTRUCTER

        public CustomerRepository() { }

        #endregion


        #region FUNCTION


        #endregion


    }
}
