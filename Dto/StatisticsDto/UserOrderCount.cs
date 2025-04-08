using FOLYFOOD.Entitys;

namespace FOLYFOOD.Dto.StatisticsDto
{
    public class UserOrderCount
    {
        public Account account { get; set; }
        public int OrderCount { get; set; }
        public double OrderTongTien { get; set; }
        public DateTime Month { get; set; }
    }
}
