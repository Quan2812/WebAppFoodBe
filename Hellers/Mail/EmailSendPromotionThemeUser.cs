using FOLYFOOD.Dto;

namespace FOLYFOOD.Hellers.Mail
{
    public class EmailSendPromotionThemeUser
    {
        public static string ThemeSendMail(string  voucherCode, int value, string username)
        {
            string changeLink = "https://polyfood.store/";
            string emailTemplate = @"
<!DOCTYPE html>
<html>
<head>
<style>
   body {
    font-family: Arial, sans-serif;
  }
  .container {
    width: 100%;
    max-width: 600px;
    margin: 0 auto;
    padding: 20px;
    border: 1px solid #ddd;
  }
  .header {
    text-align: center;
    background-color: #f2f2f2;
    padding: 10px;
  }
  .content {
    padding: 20px;
  }
  .voucher {
    background-color: #ffcc00;
    padding: 10px;
    text-align: center;
    font-size: 24px;
  }
  .button {
    display: inline-block;
    background-color: #fff;
    padding: 10px 20px;
    border: 1px black;
    text-decoration: none;
    border-radius: 4px;
    margin-top: 20px;
  }

</style>
</head>
<body>

<div class=""container"">
  <div class=""header"">
    <h1>Voucher Của Bạn Đã Đến!</h1>
  </div>
  <div class=""content"">
    <p>Xin chào " + username + @",</p>
    <p>Chúc mừng bạn! Bạn đã nhận được một voucher đặc biệt trị giá " + value + @"% cho lần mua sắm kế tiếp.</p>
    <div class=""voucher"">
      <strong>[Mã Voucher]: " + voucherCode + @"</strong>
    </div>
    <p>Đừng bỏ lỡ cơ hội tốt để tiết kiệm. Hãy đổi voucher của bạn ngay bây giờ!</p>
    <a href=""" + changeLink + @""" class=""button"">Đổi Ngay</a>
  </div>
</div>

</body>
</html>";
            return emailTemplate;

        }
    }
}
