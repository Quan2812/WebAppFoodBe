using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("product_review")]
    public class ProductReview
    {
        public int ProductReviewId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string ContentRated { get; set; }
        public int PointEvaluation { get; set; }
        public string ContentSeen { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một ProductReview thuộc về một Product
        public Product Product { get; set; }

        // Mối quan hệ: Một ProductReview thuộc về một User
        public User User { get; set; }
    }
}
