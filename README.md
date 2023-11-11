# *`A101-T6-WebsiteBanDienThoai_Admin`*
## Đồ án môn học:
1. ***Phát triển phần mềm ứng dụng thông minh***
### Đề tài: Xây dựng website bán điện thoại

## Thành viên
 
|       MSSV       |      Tên thành viên          |    Vai trò       |
| :--------------: | :--------------------------: | :--------------: |
|    2001200553    |    Phạm Tấn Thuận            |    Trưởng nhóm   |
|    2001202222    |    Ngô Văn Sơn               |    Thành viên    |
|    2001200584    |    Nguyễn Trần Hoàng Phát    |    Thành viên    |

## Chức năng đề tài
### Application
- Quản lý thông sản phẩm
- Quản lý chương trình khuyến mãi
- Quản lý đơn hàng
- Quản lý thông tin nhân viên
- Thống kê
- Phân quyền nhân viên

### Website
- Xem điện thoại/phụ kiện và thêm vào giỏ hàng
- Đặt mua điện thoại/phụ kiện

### AI
- Gợi ý sản phẩm mua kèm

## Tài liệu tham khảo
### Source Code
1. Source code của đồ án môn học Công nghệ .Net năm học trước (GV: Bùi Công Danh, Trưởng nhóm: Phạm Tấn Thuận) - Tham khảo phần SQL trong BaseRepository
3. Source code của đồ án chuyên ngành (GV: Trần Văn Thọ, Trưởng nhóm: Phạm Tấn Thuận) - Tham khảo phần DbContext và Migration
### Sản phẩm thương mại tham khảo

## Phân công nhiệm vụ và tài liệu liên quan
[Google Sheets](https://docs.google.com/spreadsheets/d/1U5_jiRfTzOF-wxRgiufHNVZSmLC6Zx-hAyzIIHhi5Iw/edit#gid=354158710)

## Cấu hình
### Cài đặt

### Hướng dẫn sử dụng
1. Sửa chuỗi connect phù hợp với máy bạn trong Databse/appsettings.json
2. Set as Startup project: Databse
3. Mở Package Manager Console > Chọn Default project: Databse
4. Chạy lệnh: update-database
5. 5. Chạy chương trình
### Hướng dẫn lập trình
1. Tạo class entity trong Domain/Entities
2. Mở Package Manager Console > Set as Startup project: Databse > Chọn Default project: Database
3. Chạy lệnh: create-migration [name_migration]
4. Chạy lệnh: update-database
5. Tạo model cho entity vừa tạo trong Services/DTOs
6. Ràng buộc các trường dữ liệu tương ứng trong Services/Validator
7. Tạo mapping tương ứng Services/Profiles
8. Tạo Repository cho module vừa tạo trogn Database/Repositories
9. Tạo control trong WinFormsApp/Resources
10. Tạo giao diện trong WinFormsApp/View
### Bổ sung
1. Project Common: Những thứ chung nhất có thể sử dụng lại nhiều lần không riêng đồ án này
2. Domain: Chứa entities, class nghiệp vụ chính.
3. Project Database: Tương tác với CSDL
4. Project Services: Xử lý nghiệp vụ
5. Project WinFormsApp: Giao diện
