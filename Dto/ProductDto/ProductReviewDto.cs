namespace FOLYFOOD.Dto.ProductDto
{
    public class ProductReviewDto
    {
        public int? ProductReviewId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public string ContentRated { get; set; }
        public int PointEvaluation { get; set; }
        public string? ContentSeen { get; set; }
        public int Status { get; set; }
    }
}
