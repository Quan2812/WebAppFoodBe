using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("sevicer")]
    public class Service
    {
        public int ServiceId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceName { get; set; }
        public double Price { get; set; }
        public string ImageService { get; set; }
        public string Describe { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Service thuộc về một ServiceType
        public ServiceType ServiceType { get; set; }

        // Mối quan hệ: Một Service có nhiều SevicerReview
        public ICollection<SevicerReview> SevicerReviews { get; set; }

        // Mối quan hệ: Một Service có nhiều ReservationDetailsService
        public ICollection<ReservationDetailsService> ReservationDetailsServices { get; set; }
    }
}
