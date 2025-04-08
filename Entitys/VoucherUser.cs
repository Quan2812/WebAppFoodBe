namespace FOLYFOOD.Entitys
{
    public class VoucherUser
    {
        public int VoucherUserId { get; set; }
        public int UserId { get; set; }
        public int voucherId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }
        public Voucher Voucher { get; set; }
    }
}
