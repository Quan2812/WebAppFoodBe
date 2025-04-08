namespace FOLYFOOD.Hellers.Mail
{
    public class TemplateResetPasswordEmail
    {
        public static string temlapteHtmlMail(string resetPasswordToken)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string baseUrl = environment == "Development" ? "http://localhost:3000" : "https://polyfood.store";
            string htmlContent = $@"
            <!DOCTYPE html>
            <html lang=""vi"">
            <head>
                <meta charset=""UTF-8"">
                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>Mẫu Email</title>
                <style>
                    /* Đoạn mã CSS của giao diện email */
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }}
                    .container {{
                        max-width: 600px;
                        margin: 0 auto;
                        padding: 20px;
                        background-color: #ffffff;
                    }}
                    h1 {{
                        text-align: center;
                        color: #333333;
                    }}
                    .image {{
                        display: block;
                        max-width: 100%;
                        height: auto;
                        margin: 20px auto;
                    }}
                    p {{
                        color: #555555;
                        line-height: 1.5;
                    }}
                    .button {{
                        display: inline-block;
                        padding: 10px 20px;
                        background-color: #4caf50;
                        color: #ffffff;
                        text-decoration: none;
                        border-radius: 5px;
                    }}
                    .button:hover {{
                        background-color: #45a049;
                    }}
                    .footer {{
                        margin-top: 20px;
                        color: #888888;
                        text-align: center;
                    }}
                </style>
            </head>
            <body>
                <div class=""container"">
                    <h1>Đặt lại mật khẩu của bạn</h1>
                    <p>Bạn đã yêu cầu đặt lại mật khẩu cho tài khoản của mình.</p>
                    <p>Vui lòng sử dụng mã sau để đặt lại mật khẩu:</p>
                    <h2 style=""text-align: center;"">{resetPasswordToken}</h2>
                    <p>Nếu bạn không yêu cầu đặt lại mật khẩu, vui lòng bỏ qua email này.</p>
                    <p>Cảm ơn bạn!</p>
                    <div class=""footer"">
                        <p>Trân trọng,</p>
                        <p>Đội ngũ Poly Food</p>
                    </div>
                    <a href=""{baseUrl}/reset-password?token={resetPasswordToken}"">Cập nhật mật khẩu tại đây</a>
                </div>
            </body>
            </html>
            ";

            return htmlContent;
        }
    }
}
