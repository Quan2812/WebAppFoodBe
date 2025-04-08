using FOLYFOOD.Dto;
using FOLYFOOD.Dto.CartDto;
using FOLYFOOD.Entitys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace FOLYFOOD.Services.cart    
{
    public class CartServicer
    {
        public readonly Context DBContext;

        public CartServicer()
        {
            DBContext = new Context();
        }

        public async Task<List<CartsResponse>> GetCarts(int userId)
        {
            Carts cart = await DBContext.Carts.Include(x=>x.cartItems).ThenInclude(x=>x.Product).ThenInclude(x=>x.ProductType).AsNoTracking().SingleOrDefaultAsync(x=>x.UserId == userId);
            List<CartsResponse> data = new List<CartsResponse>();
            if (cart == null || cart.cartItems.Count() <= 0)
            {
               return data;
            }
            foreach (var cartItem in cart.cartItems)
            {
                DateTime currentDate = DateTime.Today;
                DateTime availableDate = cartItem.Product.CreatedAt;

                TimeSpan difference = currentDate - availableDate;
                int daysDifference = difference.Days;
                CartsResponse item = new CartsResponse()
                {
                    cartItemId = Guid.NewGuid().ToString(),
                    category = new List<string>()
                    {
                        cartItem.Product.ProductType.NameProductType
                    },
                    tag = new List<string>() {
                        cartItem.Product.ProductType.NameProductType
                    },
                    discount = cartItem.Product.Discount,
                    fullDescription = cartItem.Product.fullDescription,
                    shortDescription = cartItem.Product.shortDescription,
                    id = cartItem.ProductId.ToString(),
                    sku = cartItem.ProductId.ToString() + "key" + new Random().Next(1, 199),
                    rating = 5,
                    image = new List<string>()
                    {
                        cartItem.Product.AvartarImageProduct
                    },
                    name = cartItem.Product.NameProduct,
                    price = cartItem.Product.Price,
                    stock = cartItem.Product.Quantity,
                    new_product = daysDifference <= 5,
                    quantity = cartItem.Quantity,
                    saleCount = cartItem.Product.Quantity,
            };
                data.Add(item);
            }
            
            return data;

        }

        public string AddListCartItem(CartCreateRequest value)
        {
            var user = DBContext.Users.AsNoTracking().SingleOrDefault(x => x.UserId == value.UserId);

            if (user == null)
            {
                return "không tồn tại người dùng.";
            }
            var carts = DBContext.Carts.AsNoTracking().SingleOrDefault(x => x.UserId == user.UserId);
            bool checkCartItem = DBContext.CartItems.Any(x => x.CartsId == carts.CartsId);
            if(carts != null && value.Carts.Count > 0 && !checkCartItem)
            {
                List<CartItem> items = value.Carts.Select(x=>new CartItem()
                {
                    CartsId = carts.CartsId,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                }).ToList();

               DBContext.CartItems.AddRange(items);
               DBContext.SaveChanges();
                return "đã thêm vào giỏ hàng thành công";
            }
            return "thêm thất bại";
            
        }
        public string AddCartItem(CartItemRequest value)
        {
            var user = DBContext.Users.AsNoTracking().SingleOrDefault(x=>x.UserId == value.UserId);

                if(user == null || value.Quantity <= 0)
                {
                    return "không tồn tại người dùng hoặc sản phẩm không có số lượng.";
                }
            
            

            var carts = DBContext.Carts.AsNoTracking().SingleOrDefault(x => x.UserId == user.UserId);
            var cartItem = DBContext.CartItems.AsNoTracking().SingleOrDefault(x=>x.CartsId == carts.CartsId && x.ProductId == value.ProductId);

            if(cartItem == null)
            {
                CartItem item = new CartItem()
                {
                    CartsId = carts.CartsId,
                    ProductId = value.ProductId,
                    Quantity = value.Quantity,
                };
                DBContext.CartItems.Add(item);
                DBContext.SaveChanges();
                return "đã thêm thành công";
            }
            else
            {
                if(value.IsAdd == 1)
                {
                    cartItem.Quantity = cartItem.Quantity + value.Quantity;
                }
                else
                {
                    cartItem.Quantity = cartItem.Quantity - value.Quantity;
                }
                
                if(cartItem.Quantity <=0) {
                    DBContext.CartItems.Remove(cartItem);
                }
                else
                {
                    DBContext.CartItems.Update(cartItem);
                }

                DBContext.SaveChanges();
                return "sửa giỏ hàng thành công";
            }
          

        
        }

        public string RemoveCart(int userId)
        {
            var user = DBContext.Users.AsNoTracking().SingleOrDefault(x => x.UserId == userId);

            if (user == null)
            {
                return "không tồn tại người dùng.";
            }
            var carts = DBContext.Carts.SingleOrDefault(x => x.UserId == user.UserId);
            IQueryable<CartItem> cartItem = DBContext.CartItems.Where(x=>x.CartsId == carts.CartsId).AsNoTracking();

            DBContext.CartItems.RemoveRange(cartItem);
            DBContext.SaveChanges();
            return "xóa tất cả thành công";
        }
    }
}
