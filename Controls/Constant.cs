using Common.Type;
using Domain.Entities;

namespace Common
{
    public static class Constant
    {
        public static List<Option> promotionTypes = new List<Option>() {
            new Option { label = "Giảm giá", value = Promotion.TYPE_DISCOUNT},
            new Option {label = "Giảm phần trăm", value = Promotion.TYPE_PERCENT }
        };

        public static List<Option> promotionStatuses = new List<Option>() {
            new Option { label = "Nháp", value = Promotion.STATUS_DRAFT },
            new Option { label = "Duyệt", value = Promotion.STATUS_APPROVED },
            new Option { label = "Hủy", value = Promotion.STATUS_CANCEL },

        };
    }
}
