using FOLYFOOD.Dto;

namespace FOLYFOOD.Hellers.Mail
{
    public class CancelOrderTheme
    {
        public static string ThemeSendMail(String name, string code)
        {
            string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">

<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Thông Báo Hủy Đơn</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 5px;
            box-shadow: 0px 2px 4px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #333;
        }

        p {
            color: #777;
            line-height: 1.6;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
            font-weight: bold;
        }

        .footer {
            margin-top: 20px;
            text-align: center;
            color: #777;
        }
    </style>
</head>

<body>
    <div class=""container"">
        <h1>Thông Báo Hủy Đơn </h1>
        <p>Xin chào: " + name + @" </p>
        <p>Chúng tôi rất tiếc thông báo rằng bạn đã hủy đơn hàng có mã { " + code + @"} thành công.</p>
        <p>Nếu bạn có thanh online thì vui lòng liên hệ lại với chủ shop qua số <b>0352988596</b> để được hỗ trợ hoàn tiền sớm nhất.</p>
        <p>Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ thêm, vui lòng liên hệ với chúng tôi qua email hoặc số điện thoại sau:</p>
        <p>Email: polyfood@com.fpt.com<br>Số điện thoại: 0352988596</p>
        <p>Cảm ơn con vợ " + name + @". </p>
        <a href=""#"" class=""button"">Trang Chủ</a>
        <p class=""footer"">© 2023 Tên Công Ty. Tất cả các quyền được bảo lưu.</p>
    </div>
</body>

</html>
";

         return  htmlContent;

        }
    }
}
