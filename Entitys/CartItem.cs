using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("cart_item")]
    public class CartItem
    {
        [Key]
        [Column("cart_item_id")]
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public int CartsId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Carts Carts { get; set; }
    }
}
