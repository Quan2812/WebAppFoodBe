using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("order_status")]
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một OrderStatus có nhiều Order
        public ICollection<Order> Orders { get; set; }
    }
}
