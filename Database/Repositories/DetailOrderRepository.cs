using Database.Interfaces;
using Domain.Entities;

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
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "Quantity",
            "Price",
            "ProductId",
            "CustomerId",
        };

        #endregion

        #region CONSTRUCTER

        public DetailOrderRepository() { }


        #endregion


        #region FUNCTION


        #endregion
    }
}
