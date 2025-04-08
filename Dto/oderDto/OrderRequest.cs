namespace FOLYFOOD.Dto.oderDto
{
    public class OrderRequest
    {
        public int? OrderId { get; set; }
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public int OrderStatusId { get; set; }
        public int provinces { get; set; }
        public int districts { get; set; }
        public int wards { get; set; }
        public int pickupTime { get; set; }
        public double originalPrice { get; set; }
        public string? noteOrder { set; get; }
        public double actualPrice { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<orderDetailDto.OrderDetailRequest> orderDetailDtos { get; set; }
    }
}
