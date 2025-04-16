using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("payment_order")]
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
