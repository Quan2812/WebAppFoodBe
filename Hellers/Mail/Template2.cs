namespace FOLYFOOD.Hellers.Mail
{
    public class Template2
    {
        public static string temlapteHtmlMail(string mess)
        {
            string htmlContent = $@"
<!DOCTYPE html>
<html lang=""vi"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Mẫu Email</title>
    <style>
        .container {{
  max-width: 600px;
  margin: 0 auto;
  padding: 20px;
  background-color: #f2f2f2;
}}

h1 {{
  font-size: 24px;
  color: #333;
  margin-bottom: 20px;
}}


p {{
  font-size: 16px;
  line-height: 1.5;
  color: #666;
  margin-bottom: 10px;
}}

ul.feature-list {{
  list-style-type: disc;
  margin-left: 20px;
}}

h2 {{
  font-size: 20px;
  color: #333;
  margin-bottom: 10px;
}}

.button {{
  display: inline-block;
  padding: 10px 20px;
  background-color: #007bff;
  color: #fff;
  text-decoration: none;
  border-radius: 4px;
}}

.footer {{
  margin-top: 40px;
  font-size: 14px;
  color: #888;
  text-align: center;
}}

.footer a {{
  color: #888;
  text-decoration: none;
}}
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Chào mừng bạn đến với Poly-food của chúng tôi!</h1>
        <img src=""https://res.cloudinary.com/doedovklj/image/upload/v1685894950/xyz-abc_638215169409020561end.jpg"" alt =""Hình ảnh PolyFood"" class=""image"">
        <p>Xin chân thành cảm ơn bạn đã liên hệ cho chúng tôi.</p>
        <h2>trả lời!</h2>
        <p>{mess}</p>
        <p style=""text-align: center;""><a href=""https://www.example.com"" class=""button"">Cảm ơn bạn</a></p>
        <div class=""footer"">
            <p>Trân trọng,</p>
            <p>Đội ngũ Foly food</p>
            <p>Liên hệ: 0123456789 | Email: newsletter@example.com</p>
            <p>Địa chỉ: 123 Đường ABC, Quận XYZ, Thành phố ABC</p>
            <p>© 2023 Bản quyền thuộc về Newsletter</p>
            <p style=""text-align: center;""><a href=""https://www.example.com/unsubscribe"" class=""button"">Foly Food</a></p>
        </div>
    </div>
</body>
</html>
";
            return htmlContent;

        }
    }
}
