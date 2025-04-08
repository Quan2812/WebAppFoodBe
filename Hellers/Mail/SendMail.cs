using System.Net;
using System.Net.Mail;
namespace FOLYFOOD.Hellers.Mail
{
    public class SendMail
    {
        public static string send(string mailTo, string htmlTemplate, string Subject = "",bool check = false)
        {
            // Cấu hình thông tin máy chủ SMTP
            string appPass = check ? "igyxznfpyzxngdyg" : "qbqefnmnrbrlmmqn";
            string mailAddress = check ? "notification.ltsedu@gmail.com" : "thuanlevan72@gmail.com";
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
              
                Port = 587,
                Credentials = new NetworkCredential(mailAddress, appPass),
                EnableSsl = true
            };

            try
            {
                // Tạo đối tượng MailMessage
                var message = new MailMessage();
                message.From = new MailAddress(mailAddress);
                message.To.Add(mailTo);
                message.Subject = Subject;
                message.Body = htmlTemplate;
                message.IsBodyHtml = true;
                // Gửi email
                smtpClient.Send(message);
                return "Email đã được gửi thành công.";


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gửi email: " + ex.Message);
                return "Lỗi khi gửi email: " + ex.Message;
            }
        }
    }
}
