using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.IService.IContact;
using FOLYFOOD.Services.Contact;
using FOLYFOOD.Services.order;
using FOLYFOOD.Services.product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private protected ProductService productService;

        public ProductController()
        {
            productService = new ProductService();
        }
        // GET: api/<ValuesController>
        [HttpGet, Authorize(Roles = "staff, admin")]
     
        public async Task<IActionResult> Get(int? ProductTypeId, int page = 1, int pageSize = 10, String? search = "", Double? priceFrom = null, Double? priceTo = null)
        {
            search = search ?? "";
            priceFrom = priceFrom == 0 ? Double.MinValue : priceFrom;
            priceTo = priceTo == 0 ? double.MaxValue : priceTo;
            if(priceFrom > priceTo)
            {
                double permutation = priceTo.Value;
                priceTo = priceFrom;
                priceFrom = permutation;
            }

            IQueryable<Product> data = await productService.getProducts(ProductTypeId, search, priceFrom, priceTo);
            var res = PaginationHelper.GetPagedData<Product>(data, page, pageSize);
            RetunObject<PagedResult<Product>> dataProduct = new RetunObject<PagedResult<Product>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataProduct);
        }
        [HttpGet("getlimitproductseal")]
        public async Task<IActionResult> GetLimitProductSeal()
        {
            return Ok(await productService.GetLimitProductSeal());
        }
        [HttpGet("getallproductfrontend")]
        public async Task<IActionResult> getAllProductFrontend()
        {
            return Ok(await productService.GetAllProductFrontend());
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            RetunObject<Product> res = await productService.getDetailproduct(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        [HttpGet("increaseviews/{id}")]
        public async Task<IActionResult> IncreaseViews(int id)
        {
            RetunObject<Product> res = await productService.increaseViews(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        // POST api/<ValuesController>
        [HttpPost, Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Post([FromForm] ProductDto value)
        {
            RetunObject<Product> res = await productService.CreateProduct(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
           
        }

        // PUT api/<ValuesController>/5
        [HttpPost("update/{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Put(int id, [FromForm] ProductDto value)
        {

            RetunObject<Product> res = await productService.updateProduct(id,value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("update_status/{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> PutStatus(int id)
        {
            RetunObject<Product> res = await productService.updateStatus(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        // DELETE api/<ValuesController>/5
        [HttpGet("delete/{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<Product> res = await productService.deleteProduct(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
