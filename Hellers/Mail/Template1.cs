namespace FOLYFOOD.Hellers.Mail
{
    public class Template1
    {
      public static string temlapteHtmlMail()
        {
            string htmlContent = @"
<!DOCTYPE html>
<html lang=""vi"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Mẫu Email</title>
    <style>
        /* Đoạn mã CSS của giao diện email */
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Chào mừng bạn đến với Poly Food của chúng tôi!</h1>
        <img src=""https://images.pexels.com/photos/750952/pexels-photo-750952.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"" alt =""Hình ảnh Poly Food"" class=""image"">
        <p>Xin chân thành cảm ơn bạn đã đăng ký nhận Poly Food của chúng tôi. Chúng tôi sẽ cung cấp cho bạn thông tin cập nhật về tin tức và ưu đãi mới nhất.</p>
        <h2>Ưu điểm của Poly Food:</h2>
        <ul class=""feature-list"">
            <li>Thông tin mới nhất về sản phẩm và dịch vụ của chúng tôi</li>
            <li>Ưu đãi đặc biệt và khuyến mãi hấp dẫn</li>
            <li>Chia sẻ kiến thức và thông tin hữu ích</li>
            <li>Cập nhật xu hướng mới nhất trong ngành</li>
        </ul>
        <h2>Đừng bỏ lỡ!</h2>
        <p>Để nhận các thông tin và ưu đãi đặc biệt từ chúng tôi, hãy nhấp vào nút bên dưới để đăng ký ngay:</p>
        <p style=""text-align: center;""><a href=""https://www.example.com"" class=""button"">Đăng ký ngay (chức năng đang cập nhật đừng bấm)</a></p>
        <div class=""footer"">
            <p>Trân trọng,</p>
            <p>Đội ngũ Poly Food</p>
            <p>Liên hệ: 0123456789 | Email: Poly Food@example.com</p>
            <p>Địa chỉ: ngõ 73 Giang Văn Minh Ba Đình Hà Nội</p>
            <p>© 2023 Bản quyền thuộc về Poly Food</p>
            <p style=""text-align: center;"">Cảm ơn bạn đã đăng ký</p>
        </div>
    </div>
</body>
</html>
";
            return htmlContent;

        }
    }
}
