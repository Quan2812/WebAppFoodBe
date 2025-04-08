using FOLYFOOD.Dto;
using FOLYFOOD.Dto.ProductDto.imageProductDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Services.product;
using FOLYFOOD.Services.product.ImageProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.product.imageProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageProductController : ControllerBase
    {
        private protected ImageProductService imageProductService;

        public ImageProductController()
        {
            imageProductService = new ImageProductService();
        }
        // GET: api/<ImageProductController>
        [HttpGet]
        public IActionResult Get([FromForm] ImageProductDto value)
        {
            return Ok(value);
        }

        // GET api/<ImageProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImageProductController>
        [HttpPost("{id}"), Authorize(Roles = "staff, admin")]
        public async Task<IActionResult> Post([FromForm] List<IFormFile> value, int id)
        {
            RetunObject<IQueryable<ProductImage>> res = await imageProductService.CreateListImage(value,id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
      
        }

        // PUT api/<ImageProductController>/5
        [HttpPost("updateimage/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImageProductController>/5
        [HttpGet("deleteimage/{id}")]
        public void Delete(int id)
        {
            //RetunObject<IQueryable<ProductImage>> res = await imageProductService.DeleteListImage(value, id);
            //if (res.errorOccurred)
            //{
            //    return NotFound(res);
            //}
            //return Ok(res);
        }
    }
}
