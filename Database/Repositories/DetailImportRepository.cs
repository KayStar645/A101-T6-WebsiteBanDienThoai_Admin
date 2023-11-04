using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class DetailImportRepository : BaseRepository<DetailImport>, IDetailImportRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(DetailImport);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "Quantity",
            "Price",
            "ProductId",
            "ImportBillId",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "Quantity",
            "Price",
            "ProductId",
            "ImportBillId",
        };

        #endregion

        #region CONSTRUCTER

        public DetailImportRepository() { }


        #endregion


        #region FUNCTION


        #endregion
    }
}
