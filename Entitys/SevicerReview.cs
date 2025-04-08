using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("sevicer_review")]
    public class SevicerReview
    {
        public int SevicerReviewId { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string ContentRated { get; set; }
        public int PointEvaluation { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một SevicerReview thuộc về một Service
        public Service Service { get; set; }

        // Mối quan hệ: Một SevicerReview thuộc về một User
        public User User { get; set; }
    }
}
