namespace Services.Transform
{
    public class CommonTransform
    {
        // Giới tính
        public static string male = "Nam";
        public static string female = "Nữ";
        public static string other = "Khác";

        public static string[] GetGender()
        {
            return new string[]
            {
                male,
                female,
                other
            };
        }
    }
}
