namespace FOLYFOOD.Dto.UserDto
{
    public class ResetPasswordRequest
    {
        public string ResetPasswordToken { get; set; }
        public string NewPassword { get; set; }
    }
}
