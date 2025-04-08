
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using FOLYFOOD.Entitys;
using FOLYFOOD.Services;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using FOLYFOOD.Hellers;
using FOLYFOOD.Dto;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Azure.Core;

namespace POLYFOOD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SecurityUserService SecurityUser;
        private readonly Context contextDb;
        private readonly Random rnd;
        private readonly UserService userService;
        private (string, string) GetTokenInfo(string token = "")
        {
            // Lấy token từ HttpContext
            if(token == "")
            {
                token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            }

            // Giải mã JWT và lấy thông tin accountId từ payload
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            string accountId = jwtToken.Claims.FirstOrDefault(c => c.Type == "accountId")?.Value;

            // Lấy role của người dùng từ HttpContext
            string role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

            return (accountId, role);
        }
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
            SecurityUser = new SecurityUserService();
            contextDb = new Context();
            rnd = new Random();
            userService = new UserService();
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {

            try
            {
                string imageUrl = await uplloadFile.UploadFile(file,true);
                return Ok(imageUrl); 
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("register-user")]
        public async Task<IActionResult> Register([FromForm] RegisterRequets request)
        {
            
           var data = await SecurityUser.Register(request);
            if (data == null)
            {
                return BadRequest("đăng ký người dùng thất bại");
            }
            return Ok(data);

       
        }
        [HttpPost("change-pass"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> changePass([FromBody] ChangePassDto value)
        {

            (string accountId, string role) = GetTokenInfo();
            var data = await SecurityUser.changePass(value,  accountId,  role);
            if (data == null)
            {
                return BadRequest("đổi mật khẩu thất bại");
            }
            return Ok(data);
        }
        [HttpPost("register-staff")]
        public async Task<IActionResult> RegisterStaff([FromForm] RegisterRequets request)
        {

            var data = await SecurityUser.RegisterStaff(request);
            if (data == null)
            {
                return BadRequest("đăng ký người dùng thất bại");
            }
            return Ok(data);


        }
        [HttpPost("update-role"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> UpdateRoleRequest(UpdateRoleRequest request)
        {
            
            var data = await SecurityUser.ChangeUpdateRole(request);
            if (data == null)
            {
                return BadRequest("cập nhật quyền thất bại");
            }
            return Ok(data);
        }
        [HttpPost("get-role") , Authorize(Roles = "admin")]
        public async Task<IActionResult> GetRole()
        {
            var data = await SecurityUser.GetRole();
            return Ok(data);
        }
        [HttpPost("login")]
        public IActionResult Authenticate([FromBody] LoginRequest login)
        {
            var loginResponse = new LoginResponse { };
            //loginService.checkLogin(login.UserName, login.Password);
            var data = SecurityUser.checkLogin(login.email, login.Password);
         
            // if credentials are valid
            if (data != null)
            {
                if (data.Status != 1)
                {
                    return BadRequest("Tài khoảng đã bị khóa!");
                }
                string token = CreateToken(data.UserName, data.AccountId, data.Decentralization.AuthorityName.ToLower());

                loginResponse.Token = token;
                loginResponse.responseMsg = new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK
                };

                //return the token
                return Ok(new { loginResponse, data, Decentralization = data.Decentralization.AuthorityName.ToLower() });
            }
            else
            {
                // if username/password are not valid send unauthorized status code in response               
                return BadRequest("Username or Password Invalid!");
            }
        }
        [HttpPost("refresh-token")]
        public string RefreshToken(RefreshTokenRequest value)
        {
            (string accountId, string role) = GetTokenInfo(value.Token);
            var account = SecurityUser.CheckUserExists(value.UserId, accountId);
            if (account == null)
            {
                return "RefreshToken thất bại";
            }
            string token = CreateToken(account.UserName, account.AccountId, account.Decentralization.AuthorityName.ToLower());
            return token;
        }

        private string CreateToken(string username,int accountId, string role)
        {

            List<Claim> claims = new()
            {                    
                //list of Claims - we only checking username - more claims can be added.
                new Claim("username", Convert.ToString(username)),
                new Claim("accountId", Convert.ToString(accountId)),
                new Claim("role", Convert.ToString(role)),
                 new Claim(ClaimTypes.Role, role)
        };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(4),
                signingCredentials: cred                                                                                
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
