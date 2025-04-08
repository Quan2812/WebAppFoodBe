using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services.product;
using FOLYFOOD.Services.product.ImageProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.product.ProductReviews
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductReviewController : ControllerBase
    {
        private protected ProductReviewService productReviewService;


        public ProductReviewController()
        {
            productReviewService = new ProductReviewService();
        }
        // GET: api/<ProductReviewController>
        [HttpGet, Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            IQueryable<ProductReview> data = await productReviewService.getProductReview();
            var res = PaginationHelper.GetPagedData<ProductReview>(data, page, pageSize);
            RetunObject<PagedResult<ProductReview>> dataProduct = new RetunObject<PagedResult<ProductReview>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataProduct);
        }
        [HttpGet("getforproduct")]
        public async Task<IActionResult> getReviewForProduct(int ProductId,int page = 1, int pageSize = 10)
        {
            IQueryable<ProductReview> data = await productReviewService.getReviewForProduct(ProductId);
            var res = PaginationHelper.GetPagedData<ProductReview>(data, page, pageSize);
            RetunObject<PagedResult<ProductReview>> dataProduct = new RetunObject<PagedResult<ProductReview>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataProduct);
        }
        // GET api/<ProductReviewController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            RetunObject<ProductReview> res = await productReviewService.getDetailProductReview(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // POST api/<ProductReviewController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductReviewDto value)
        {
            RetunObject<ProductReview> res = await productReviewService.createReview(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<ProductReviewController>/5
        [HttpPost("update/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpPost("phanhoi/{ProductReviewId}")]
        public async Task<IActionResult> replyReview(int ProductReviewId, [FromBody] string mess)
        {
            RetunObject<ProductReview> res = await productReviewService.replyReview( ProductReviewId, mess);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // DELETE api/<ProductReviewController>/5
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<ProductReview> res = await productReviewService.deleteReview(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
