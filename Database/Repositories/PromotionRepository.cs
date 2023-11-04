using Database.Interfaces;
using Domain.Entities;

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


        #endregion
    }
}
