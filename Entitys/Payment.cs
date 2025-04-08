using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("payment")]
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public string PaymentMethod { get; set; }
        public double OriginalPrice { get; set; }
        public double ActualPrice { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Payment thuộc về một Booking
        public Booking Booking { get; set; }
    }
}
