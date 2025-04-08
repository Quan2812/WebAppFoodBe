using FOLYFOOD.Services.order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private protected OrderStatusServicer orderStatusServicer;

        public OrderStatusController()
        {
            orderStatusServicer = new OrderStatusServicer();
        }
        // GET: api/<OrderStatusController>
        [HttpGet, Authorize(Roles = "admin")]
        public async Task<IActionResult> Get()
        {
            return Ok(await orderStatusServicer.getOrderStatus());
        }

        
    }
}
