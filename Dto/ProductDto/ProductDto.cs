namespace FOLYFOOD.Dto.ProductDto
{
    public class ProductDto
    {
        public int? ProductTypeId { get; set; }
        public string NameProduct { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public IFormFile? AvartarImageProduct { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public int? Discount { get; set; }
        public int? Status { get; set; }
    }
}
