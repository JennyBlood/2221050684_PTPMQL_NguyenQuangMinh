1, Mô hình MVC
Model – View – Controller.
Model dùng để quản lý dữ liệu và xử lý nghiệp vụ, thường chứa các class dữ liệu đại diện cho các bảng trong database.
View có chức năng hiển thị giao diện người dùng, mỗi controller sẽ có một thư mục View tương ứng, bên trong chứa các file .cshtml, mỗi file gắn với một Action đã khai báo trong Controller.
Controller nhận request từ người dùng, xử lý logic và trả dữ liệu cho View.
Luồng hoạt động: người dùng gửi request → Controller nhận request → Controller gọi Model xử lý dữ liệu → Controller trả dữ liệu cho View → View hiển thị kết quả ra trình duyệt.
2, Định tuyến Route
Định tuyến là cơ chế dùng để xác định URL sẽ gọi tới Controller và Action nào.
Luồng xử lý: URL → Controller → Action → View.
Khi người dùng truy cập URL này, hệ thống hiểu Controller là HomeController và Action là Index().
Hệ thống thực thi HomeController.Index() và trả về View Views/Home/Index.cshtml.
Pattern mặc định: "{controller=Home}/{action=Index}/{id?}".
Nếu URL không chỉ rõ Controller hoặc Action thì hệ thống sẽ dùng mặc định là Home và Index, theo đúng thứ tự controller trước rồi đến action.
Khi tạo controller mới cần tạo thư mục View cùng tên, trong thư mục đó tạo file View trùng với Action đã khai báo.
#3 Namespace
Namespace = nhóm các class lại với nhau
Dùng để tránh trùng tên và quản lý code gọn gàng
Nói đơn giản Namspace = hộp chứa đựng class
4, Controller and View
Controller là thành phần xử lý request từ người dùng, thực hiện logic, gọi Model khi cần và quyết định trả về View hay dữ liệu.
View là giao diện hiển thị, không xử lý logic nghiệp vụ mà chỉ dùng để trình bày dữ liệu.
Mối quan hệ giữa Controller và View theo luồng: URL → Controller → Action → View (đã trình bày ở trên).