namespace FOLYFOOD.Dto.voucherDto
{
    public class VoucherCreateRequest
    {
        public int? voucherId { get; set; }
        public string VoucherName { get; set; }
        public string? VoucherCode { get; set; }
        public int Valuevoucher { get; set; }
        public int CountVoucher { get; set; }
        public DateTime expirationDate { get; set; }
    }
}
