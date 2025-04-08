using CloudinaryDotNet;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.oderDto;
using FOLYFOOD.Dto.oderDto.orderDetailDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Hellers.vnPay;
using FOLYFOOD.Services.Contact;
using FOLYFOOD.Services.order;
using FOLYFOOD.Services.typeProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private (string, string) GetTokenInfo()
        {
            // Lấy token từ HttpContext
            string token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            // Giải mã JWT và lấy thông tin accountId từ payload
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            string accountId = jwtToken.Claims.FirstOrDefault(c => c.Type == "accountId")?.Value;

            // Lấy role của người dùng từ HttpContext
            string role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

            return (accountId, role);
        }
        private protected OrderServicer orderServicer;

        public OrderController()
        {
            orderServicer = new OrderServicer();
        }
        [HttpPost("orderPayVn")]
        public async Task<IActionResult> orderPayVn(long amount)
        {
            //Get Config Info

            string vnp_Returnurl = "https://localhost:7064/vnpay_return"; //URL nhan ket qua tra ve 
            string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = "NX0E4Z3Y"; //Ma định danh merchant kết nối (Terminal Id)
            string vnp_HashSecret = "BUEOSSZUUHLMPYVUCKRIUFEJRRWZREHH"; //Secret Key

            //Get payment input
            OrderInfo order = new OrderInfo();
            order.OrderId = DateTime.Now.Ticks; // Giả lập mã giao dịch hệ thống merchant gửi sang VNPAY
            order.Amount = amount; // Giả lập số tiền thanh toán hệ thống merchant gửi sang VNPAY 100,000 VND
            order.Status = "0"; //0: Trạng thái thanh toán "chờ thanh toán" hoặc "Pending" khởi tạo giao dịch chưa có IPN
            order.CreatedDate = DateTime.Now;
            //Save order to db

            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (order.Amount * 100).ToString()); 

            vnpay.AddRequestData("vnp_CreateDate", order.CreatedDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", GetIpAddress(HttpContext));

            vnpay.AddRequestData("vnp_Locale", "vn");
            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + order.OrderId);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", order.OrderId.ToString()); // Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất dùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày

            //Add Params of 2.1.0 Version
            //Billing

            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
           
            return Ok(paymentUrl);
        }
        private static string GetIpAddress(HttpContext httpContext)
        {
            string ipAddress = httpContext.Connection.RemoteIpAddress.ToString();
            return ipAddress;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.GetAllOrders();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("getwaitingorder"), Authorize(Roles = "admin")]
        public async Task<IActionResult> getWaitingOrder(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.getWaitingOrder();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("getcomplete"), Authorize(Roles = "admin")]
        public async Task<IActionResult> getOrderComplete(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.getOrderComplete();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("getordersAreBeingDelivered"), Authorize(Roles = "admin")]
        public async Task<IActionResult> getOrdersAreBeingDelivered(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.getOrdersAreBeingDelivered();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("orderIsCanceled"), Authorize(Roles = "admin")]
        public async Task<IActionResult> orderIsCanceled(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.orderIsCanceled();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("OrderHasBeenConfirmed"), Authorize(Roles = "admin")]
        public async Task<IActionResult> OrderHasBeenConfirmed(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.OrderHasBeenConfirmed();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("OrderCanceledByCustomer"), Authorize(Roles = "admin")]
        public async Task<IActionResult> OrderCanceledByCustomer(int page = 1, int pageSize = 10)
        {
            var data = await orderServicer.OrderCanceledByCustomer();
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("getDetailForEmail/{id}"), Authorize(Roles = "client, admin")]
        public async Task<IActionResult> GetOrderEmail(int id,string? searchCode,[FromQuery] int page = 1,[FromQuery] int pageSize = 6)
        {
            (string accountId, string role) = GetTokenInfo();
            var data = await orderServicer.GetOrderForUserId(id, accountId, role, searchCode);
            var res = PaginationHelper.GetPagedData(data, page, pageSize);
            RetunObject<PagedResult<Order>> test = new RetunObject<PagedResult<Order>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("getDetail/{id}"), Authorize(Roles = "admin")]
        public async Task<IActionResult> getDetail(int id)
        {
            var data = await orderServicer.getDetail(id);
            if (data.Count() <= 0)
            {
                return NotFound("không tồn tại sản phẩm trong hóa đơn");
            }
            return Ok(data);
        }
        // GET api/<OrderController>/5
        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            var data = await orderServicer.getOrderForCodeOrder(code);
            if (data.errorOccurred)
            {
                return NotFound(data);
            }
            return Ok(data);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderRequest value)
        {
            var res = await orderServicer.CreateNewOrder(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<OrderController>/5
        [HttpPost("updateStatusOrder")]
        public async Task<IActionResult> Put(int id, int idStatus)
        {
            var res = await orderServicer.updateStatusOrder(id,idStatus);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("CompleteOrder")]
        public async Task<IActionResult> CompleteOrder([FromForm] CompleteOrderRequest value)
        {
            var res = await orderServicer.CompleteOrder(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpGet("IsUserPurchasedProduct/{id}/{idProduct}")]
        public async Task<IActionResult> IsUserPurchasedProduct(int id, int idProduct)
        {
            bool isPurchased = await orderServicer.IsUserPurchasedProduct(id, idProduct);
            return Ok(new
            {
                isPurchased
            });
        }
        [HttpPost("cancelOrder/{code}"), Authorize(Roles = "client, admin")]
        public async Task<IActionResult> cancelOrder(string code, [FromQuery] string message)
        {
            (string accountId, string role) = GetTokenInfo();
            var res = await orderServicer.cancelOrder(code, accountId, role, message);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        // DELETE api/<OrderController>/5
        [HttpGet("deleteOrder/{id}"), Authorize(Roles = "admin")]
        public void Delete(int id)
        {
        }
    }
}
