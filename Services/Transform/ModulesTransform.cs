namespace Services.Transform
{
    public class ModulesTransform
    {
        public class Common
        {
            public const string InternalCode = "mã ";

            public const string Name = "tên ";

            public const string Address = "địa chỉ ";

            public const string Phone = "số điện thoại ";

            public const string DateOfBirth = "ngày sinh ";

            public const string Type = "loại ";

            public const string Status = "trạng thái ";

            public const string quantity = "số lượng ";

            public const string price = "đơn giá ";
        }

        public class Distributor
        {
            public const string module = "nhà cung cấp ";        }

        public class Employee
        {
            public const string module = "nhân viên ";
        }

        public class Color
        {
            public const string module = "màu sắc ";
        }

        public class Category
        {
            public const string module = "danh mục ";
        }

        public class Capacity
        {
            public const string module = "dung lượng ";
        }    

        public class Specifications
        {
            public const string module = "thông số kỹ thuật ";
        }

        public class DetailSpecifications
        {
            public const string module = "thông số ";

            public const string obj = "tên thông số và giá trị thông số ";

            public const string value = "giá trị thông số ";
        }

        public class Product
        {
            public const string module = "sản phẩm ";

            public const string color = "màu sắc ";

            public const string capacity = "dung lượng ";
        }

        public class Promotion
        {
            public const string module = "chương trình khuyến mãi ";

            public const string start = "thời gian bắt đầu ";

            public const string end = "thời gian kết thúc ";

            public const string discount = "giảm giá ";

            public const string percentMax = "% giảm tối đa ";

            public const string percent = "giảm % ";

            public const string discountMax = "tiền giảm tối đa ";
        }

        public class Order
        {
            public const string module = "đơn hàng ";

            public const string type = "trạng thái ";

            public const string details = "chi tiết đơn hàng ";
        }

        public class DetailOrder
        {
            public const string module = "chi tiết đơn hàng ";
        }
    }
}
