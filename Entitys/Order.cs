using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("order")]
    public class Order
    {
        public int OrderId { get; set; }
        public string CodeOrder { get; set; }
        public int PaymentOrderPaymentId { get; set; }
        public int? UserId { get; set; }
        public int OrderStatusId { get; set; }
        public int provinces { get; set; }
        public int districts { get; set; }
        public int wards { get; set; }
        public int pickupTime { get; set; }
        public string ReasonForCancellation { get; set; }
        public double originalPrice { get; set; }
        public double actualPrice { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string ImageComplete { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string noteOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // Mối quan hệ: Một Order có nhiều OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }

        // Mối quan hệ: Một Order thuộc về một OrderStatus
        public OrderStatus OrderStatus { get; set; }

        public User User { get; set; }

        public PaymentOrder PaymentOrder { get; set; }
    }
}
