using CloudinaryDotNet.Actions;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.UserDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.imageChecks;
using FOLYFOOD.Hellers.Mail;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.user
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;
        private readonly Context _dbContext;

        public UserController()
        {
            userService = new UserService();
            _dbContext = new Context();
        }
        

        [HttpGet, Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Get(int? roleId, int page = 1, int pageSize = 10,string? searchName = "")
        {
            searchName = searchName ?? "";
            var accounts = await userService.getListUser(searchName, roleId);
            var res = PaginationHelper.GetPagedData(accounts, page, pageSize);
            RetunObject<PagedResult<Account>> test  =new RetunObject<PagedResult<Account>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpPost("sendMail")]
        public async Task<IActionResult> sendMail(MailPointRequest mailPointRequest)
        {
          string str = SendMail.send(mailPointRequest.Email, CourseNotificationEmailTheme.ThemeSendMail(mailPointRequest), "FolyFood thông báo",true);
           return Ok(str);
        }
        [HttpPost("sendMail/welcome-to-admission")]
        public async Task<IActionResult> Admission([FromForm]MailWelcomeToAdmissionDTO mailPointRequest)
        {
            string str = MailKitSend.SendEmailWithAttachment(mailPointRequest.studentEmail, "FolyFood thông báo", EmailAdmissionForm.GenerateWelcomeEmail(mailPointRequest), true, mailPointRequest.Attachments);
            return Ok(str);
        }
        [HttpPost("check-token")]
        public async Task<IActionResult> CheckToken(string token)
        {
   
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            // Kiểm tra mã token và kiểm tra thời gian hết hạn
            var user = await _dbContext.Accounts.SingleOrDefaultAsync(x => x.ResetPasswordToken == token && x.ResetPasswordTokenExpiry > vietnamTime);
            if (user == null || token == "null")
            {
                return BadRequest("Invalid or expired reset token");
            }
            if (user.ResetPasswordToken == "null")
            {
                return BadRequest("Invalid or expired reset token");
            }
            return Ok("Token hợp lệ");
        }
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {
            string resetPasswordToken = model.ResetPasswordToken;
            string newPassword = model.NewPassword;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
            // Kiểm tra mã token và kiểm tra thời gian hết hạn
            var user = await _dbContext.Accounts.SingleOrDefaultAsync(x => x.ResetPasswordToken == resetPasswordToken && x.ResetPasswordTokenExpiry > vietnamTime);
            if (user == null || model.ResetPasswordToken == "null")
            {
                return BadRequest("Invalid or expired reset password token");
            }
            if(user.ResetPasswordToken == "null")
            {
                return BadRequest("Invalid or expired reset password token");
            }
            // Cập nhật mật khẩu mới cho người dùng
            user.Password = BCryptNet.HashPassword(model.NewPassword); // Hãy sử dụng thuật toán băm mật khẩu phù hợp
            user.ResetPasswordToken = "null";
            user.ResetPasswordTokenExpiry = vietnamTime.AddHours(-1000);
            await _dbContext.SaveChangesAsync();

            return Ok("Password reset successful");
        }
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await userService.getOneUser(id);
            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpGet("change-status/{id}"), Authorize(Roles ="admin")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var user = await userService.changeStatus(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest model)
        {
            var user = await _dbContext.Accounts.SingleOrDefaultAsync(x => x.Email == model.Email);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            // Lấy múi giờ của Việt Nam
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);

            // Thêm 1 giờ vào múi giờ của Việt Nam
            DateTime resetPasswordTokenExpiry = vietnamTime.AddHours(1);
            // Tạo và lưu trữ mã đặt lại mật khẩu
            user.ResetPasswordToken = GenerateResetPasswordToken.GenerateResetPassToken(); // tạo token
            user.ResetPasswordTokenExpiry = resetPasswordTokenExpiry;
            await _dbContext.SaveChangesAsync();

            // Gửi email chứa liên kết đặt lại mật khẩu đến người dùng
            SendMail.send(user.Email,TemplateResetPasswordEmail.temlapteHtmlMail(user.ResetPasswordToken), "Đặt lại mật khẩu ứng dụng");

            return Ok("Reset password email sent");
        }

        // POST api/<UserController>
        [HttpPost, Authorize(Roles = "staff, admin")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPost("updateUser/{id}"), Authorize(Roles = "client, admin")]
        public async Task<IActionResult> Put(int id, [FromForm] UserUpdateClient value)
        {
            // Lấy token từ HttpContext
            string token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            // Giải mã JWT và lấy thông tin accountId từ payload
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            string accountId = jwtToken.Claims.FirstOrDefault(c => c.Type == "accountId")?.Value;

            // Lấy role của người dùng từ HttpContext
            string role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

            RetunObject<Account> data = await userService.updateOneAccount(value, id, accountId, role);
            return Ok(data);
        }
        [HttpPost("update_avatar/{id}"), Authorize(Roles = "client, admin")]
        public async Task<IActionResult> PutImageAvatar(int id, IFormFile Avatar)
        {
            // Lấy token từ HttpContext
            string token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            // Giải mã JWT và lấy thông tin accountId từ payload
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            string accountId = jwtToken.Claims.FirstOrDefault(c => c.Type == "accountId")?.Value;

            // Lấy role của người dùng từ HttpContext
            string role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

            RetunObject<string> link = await userService.updateImageAvatar(Avatar, id, accountId, role);
            return Ok(link);
        }

        // DELETE api/<UserController>/5
        [HttpGet("delete/{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<Account> data = await userService.DeleteUser(id);
            if (data.errorOccurred)
            {
                return NotFound(data);
            }
            return Ok(data);
        }
    }
}
