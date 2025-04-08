namespace FOLYFOOD.Dto.oderDto.orderDetailDto
{
    public class OrderDetailRequest
    {
        public int? OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class CompleteOrderRequest
    {
        public int OrderId { get; set;}
        public IFormFile formFile { get; set; }
    }
}
