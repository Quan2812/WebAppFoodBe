using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{

    [Table("user")]
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int AccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Account Account { get; set; }

        // Mối quan hệ: Một User có nhiều ProductReview
        public ICollection<ProductReview> ProductReviews { get; set; }

        // Mối quan hệ: Một User có nhiều SevicerReview
        public ICollection<SevicerReview> SevicerReviews { get; set; }

        // Mối quan hệ: Một User có nhiều Booking
        public ICollection<Booking> Bookings { get; set; }

        public ICollection<VoucherUser> VoucherUsers { get; set; }

        public Carts Carts { get; set; }
    }
}
