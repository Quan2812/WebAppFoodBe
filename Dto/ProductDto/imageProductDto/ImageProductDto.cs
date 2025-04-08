namespace FOLYFOOD.Dto.ProductDto.imageProductDto
{
    public class ImageProductDto
    {
        public int? ProductImageId { get; set; }
        public string Title { get; set; }
        public IFormFile? ImageProduct { get; set; }
        public int? ProductId { get; set; }
        public int? Status { get; set; }
    }
}
