﻿namespace Services.Transform
{
    public static class IdentityTransform
    {
        public static string UserAlreadyExists(string userName)
        {
            return $"Tên người dùng {userName} đã tồn tại!";
        }

        public static string UserNotExists(string userName)
        {
            return $"Không tìm thấy người dùng {userName}!";
        }

        public static string InvalidCredentials(string userName)
        {
            return $"Thông tin xác thực của người dùng {userName} không hợp lệ!";
        }

        public static string ForbiddenException()
        {
            return "Bạn không được phép truy cập tài nguyên này!";
        }
    }   
}
