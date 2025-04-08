namespace FOLYFOOD.Entitys
{
    public class Voucher
    {
        public int voucherId { get; set; }
        public string VoucherName { get; set; }
        public string VoucherCode { get; set; }
        public int Valuevoucher { get; set; }
        public int CountVoucher { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<VoucherUser> VoucherUsers { get; set; }
    }
}
