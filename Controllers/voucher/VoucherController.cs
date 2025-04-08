using CloudinaryDotNet;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.voucherDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services;
using FOLYFOOD.Services.product;
using FOLYFOOD.Services.voucher;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.voucher
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly VoucherService voucherService;
        private readonly Context _dbContext;

        public VoucherController()
        {
            voucherService = new VoucherService();
            
        }
        // GET: api/<VoucherController>
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            IQueryable<Voucher> data = await voucherService.GetVoucher();
            var res = PaginationHelper.GetPagedData<Voucher>(data, page, pageSize);
            RetunObject<PagedResult<Voucher>> dataVoucher = new RetunObject<PagedResult<Voucher>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataVoucher);
        }

        // GET api/<VoucherController>/5
        [HttpGet("{userId}/{codeVoucher}")]
        public async Task<IActionResult> UseVoucher(int userId, string codeVoucher)
        {
            RetunObject<Voucher> res = await voucherService.UseVoucher(userId, codeVoucher);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("{userId}/{codeVoucher}")]
        public async Task<IActionResult> ApplyVoucher(int userId, string codeVoucher)
        {
            RetunObject<VoucherUser> res = await voucherService.ApplyVoucher(userId, codeVoucher);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        // POST api/<VoucherController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VoucherCreateRequest value)
        {
            RetunObject<Voucher> res = await voucherService.CreateVoucher(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        [HttpPost("send-promotion")]
        public async Task<IActionResult> SendPromotion([FromBody] VoucherMailRequest value)
        {
            RetunObject<User> res = await voucherService.sendMailPromotionToUser(value.UserId,value.VoucherId);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        [HttpGet("users-without-promotion-usage/{voucherId}")]
        public async Task<IActionResult> UsersWithoutPromotionUsage(int voucherId)
        {
            IQueryable<User> data = await voucherService.GetUsersWithoutPromotionUsage(voucherId);
            return Ok(data);
        }

        // PUT api/<VoucherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VoucherController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<Voucher> res = await voucherService.DeleteVoucher(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
