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
- Quản lý chương trình khuyến mãi (dự tính làm thêm)
- Quản lý đơn hàng
- Quản lý thông tin nhân viên
- Thống kê

### Website
- Xem điện thoại/phụ kiện và thêm vào giỏ hàng
- Đặt mua điện thoại/phụ kiện

### AI
- Gợi ý sản phẩm mua kèm cho khách hàng

## Tài liệu tham khảo
### Source Code

### Sản phẩm thương mại tham khảo

## Phân công nhiệm vụ và tài liệu liên quan
[Google Sheets](https://docs.google.com/spreadsheets/d/1U5_jiRfTzOF-wxRgiufHNVZSmLC6Zx-hAyzIIHhi5Iw/edit#gid=354158710)

## Cấu hình
### Cài đặt

### Hướng dẫn sử dụng
1. Sửa chuỗi connect phù hợp với máy bạn trong WinFormsApp/appsettings.json
2. Set as Startup project: WinFormsApp
3. Mở Package Manager Console > Chọn Default project: WinFormsApp
4. Chạy lệnh: update-database
### Hướng dẫn lập trình
1. Tạo class entity trong WinFormsApp/Infrastructure/Entities
2. Mở Package Manager Console > Chọn Default project: WinFormsApp
3. Chạy lệnh: create-migration [name_migration]
4. Chạy lệnh: update-database
5. Tạo model cho entity vừa tạo trong WinFormsApp/Models
6. Tạo Repository cho Model vừa tạo trogn WinFormsApp/Repositories
7. Tạo giao diện trong WinFormsApp/View
### Bổ sung
1. Project Controls: Nơi sẽ viết những Controls chung do lập trình viên tự custom
2. Project Database: Nơi sẽ viết base để xử lý dữ liệu
3. Project Services: Nơi sẽ viết những hàm xử lý hỗ trợ chung do lập trình viên tự custom
4. Project WinFormsApp: Nơi sẽ khai báo, xử lý tất cả nghiệp vụ liên quan tới phần mềm
