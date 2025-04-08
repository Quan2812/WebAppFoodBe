using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("carts")]
    public class Carts
    {
        [Key]
        [Column("carts_id")]
        public int CartsId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User user { get; set; }
        public List<CartItem> cartItems { get; set; }  
    }
}
