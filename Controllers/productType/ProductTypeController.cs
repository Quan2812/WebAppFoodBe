using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductType;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services.Contact;
using FOLYFOOD.Services.typeProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.productType
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private protected TypeProductService TypeProductService;

        public ProductTypeController()
        {
            TypeProductService = new TypeProductService();
        }
        // GET: api/<ProductTypeController>
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            PagedResult<ProductType> res = PaginationHelper.GetPagedData(await TypeProductService.getProductType(), page, pageSize);
            RetunObject<PagedResult<ProductType>> test = new RetunObject<PagedResult<ProductType>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }
        [HttpGet("GetCategoryFrontend")]
        public async Task<IActionResult> GetCategoryFrontend()
        {
            return Ok(await TypeProductService.getProductTypeFrontend());
        }

        // GET api/<ProductTypeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = await TypeProductService.getTypeProductDetail(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // POST api/<ProductTypeController>
        [HttpPost, Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Post([FromForm] ProductTypeDto data)
        {
            var res =  await TypeProductService.createProductType(data);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<ProductTypeController>/5
        [HttpPost("update/{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Put(int id, [FromForm] ProductTypeDto data)
        {
            var res = await TypeProductService.updateProductType(id,data);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // DELETE api/<ProductTypeController>/5
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await TypeProductService.DeleteproductType(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
