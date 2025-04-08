namespace FOLYFOOD.Entitys
{
    public class LoginRequest
    {
        public LoginRequest()
        {

            this.Password = String.Empty;

        }

        public string email { get; set; }
        public string Password { get; set; }
    }

}
