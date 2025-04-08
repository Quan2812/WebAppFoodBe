using FOLYFOOD.Entitys;

namespace FOLYFOOD.Dto.StatisticsDto
{
    public class ProductSale
    {
        public int ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public double SalePercentage { get; set; }
        public Product Product { get; set; }
    }
}
