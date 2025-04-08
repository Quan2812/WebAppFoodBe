using FOLYFOOD.Dto.CartDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Services;
using FOLYFOOD.Services.cart;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.cart
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartServicer cartServicer;

        public CartController()
        {
            cartServicer = new CartServicer();  
        }
        // GET: api/<CartController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            List<CartsResponse> res = await cartServicer.GetCarts(id);
            return Ok(res);  
        }
        [HttpGet("remove-cart/{id}")]
        public async Task<IActionResult> RemoveAllCart(int id)
        {
            return Ok(cartServicer.RemoveCart(id));
        }
        [HttpGet("update-cart-item/{productId}/{userId}/{quantity}/{IsAdd}")]
        public  String ChangeQuantity(int productId, int userId,int quantity,int IsAdd)
        {
            CartItemRequest value = new CartItemRequest()
            {
                Quantity = quantity,
                ProductId = productId,
                UserId = userId,
                IsAdd = IsAdd
            };
            return cartServicer.AddCartItem(value);
        }
        // POST api/<CartController>
        [HttpPost]
        public IActionResult Post([FromBody] CartItemRequest value)
        {
            return Ok(cartServicer.AddCartItem(value));
        }
        [HttpPost("add-cart-list")]
        public IActionResult PostCartList([FromBody] CartCreateRequest value)
        {
            return Ok(cartServicer.AddListCartItem(value));
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
