using System.ComponentModel.DataAnnotations;

namespace FOLYFOOD.Entitys
{

    public class PaymentOrder
    {
        [Key]
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentTitle { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // Mối quan hệ: Một Payment thuộc về một Booking
        public ICollection<Order> Order { get; set; }
    }
}
