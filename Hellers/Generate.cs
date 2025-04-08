namespace FOLYFOOD.Hellers
{
    public class Generate
    {
        public static string GenerateOrderCode()
        {
            // Lấy thời gian hiện tại
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            // Tạo một giá trị ngẫu nhiên
            Random random = new Random();
            string randomValue = random.Next(1000, 9999).ToString();

            // Kết hợp thời gian và giá trị ngẫu nhiên để tạo mã đơn hàng
            string orderCode = "poly__"+timestamp + randomValue;

            return orderCode;
        }
    }
}
