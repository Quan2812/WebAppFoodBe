using System.Security.Cryptography;
using System.Text;

namespace FOLYFOOD.Hellers
{
    public class GenerateResetPasswordToken
    {
        public static string GenerateResetPassToken()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[64];
                rng.GetBytes(tokenData);
                string token = Convert.ToBase64String(tokenData).Replace("+", "-").Replace("/", "_").Replace("=", "").Substring(0, 60);
                return token;
            }
        }


        public static string GenerateShortenedToken(string token)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(token);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
