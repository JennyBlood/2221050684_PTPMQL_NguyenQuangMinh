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
5,Viewbag:
-	Viewbag là 1 cách truyền dữ liệu từ controller sang View 
-	Là 1 dynamic ofject, không cần khai báo kiểu
-	Chỉ tồn tại 1 request
-	Thực chất là 1 wrapper của Viewdata
Ưu điểm:
-	Dễ dùng, nhanh
-	Phù hợp dữ liệu nhỏ (title, message, thông báo)
Nhược điểm:
-	Không kiểm soát kiểu dữ liệu
-	Dễ lỗi khi gõ sai tên
-	Không dùng được sau RedirectToAction
So sánh nhanh:
-	ViewBag ≈ ViewData
-	TempData dùng cho redirect
-	Model (strongly typed) là cách nên dùng trong dự án thật
6, Ví dụ sử dụng ViewBag để gửi dữ liệu từ Controller về View
 - Ví dụ: 
 ViewBag: public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.Title = "Trang chủ";
        ViewBag.Message = "Chào mừng bạn đến với ASP.NET MVC";
        ViewBag.Count = 5;
        return View();
    }
}
View Index:
@{ViewBag.Title = "Index";}
<h2>@ViewBag.Title</h2>
<p>@ViewBag.Message</p>
<p>Số lượng: @ViewBag.Count</p>
7, Gửi nhận dữ liệu giữa View và Controller thông qua Submit form
 a, Nguyên lý hoạt động
Người dùng nhập dữ liệu vào form trong View
Nhấn Submit
Dữ liệu được gửi lên Controller
Controller nhận – xử lý – trả kết quả về View
 b, Kết luận
Submit form là cách phổ biến nhất để gửi dữ liệu
View → Controller qua POST
Controller → View qua Model / ViewBag
Model Binding là trọng tâm cần nhớ