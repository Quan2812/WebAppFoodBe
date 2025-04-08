namespace FOLYFOOD.Dto.CartDto
{
    public class CartCreateRequest
    {
        public int UserId { get; set; }

        public List<CartItemRequest> Carts { get; set; }

    }
    public class CartItemRequest
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }

        public int IsAdd { get; set; }
    }
}
