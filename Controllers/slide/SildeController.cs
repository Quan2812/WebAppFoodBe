using CloudinaryDotNet;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.slideDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services.product;
using FOLYFOOD.Services.slide;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.slide
{
    [Route("api/[controller]")]
    [ApiController]
    public class SildeController : ControllerBase
    {
        private protected SlideService
             slideService;

        public SildeController()
        {
            slideService = new SlideService();
        }
        // GET: api/<SildeController>
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            IQueryable<Slides> data = await slideService.GetSlides();
            var res = PaginationHelper.GetPagedData<Slides>(data, page, pageSize);
            RetunObject<PagedResult<Slides>> dataProduct = new RetunObject<PagedResult<Slides>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataProduct);
          
        }
        [HttpGet("slide-frontend")]
        public async Task<IActionResult> Get()
        {
            return Ok(await slideService.ShowSlideFrontend());
        }
        // GET api/<SildeController>/5
        [HttpGet("active/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            RetunObject<FOLYFOOD.Entitys.Slides> res = await slideService.ActiveSlide(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // POST api/<SildeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SildeRequest value)
        {
            RetunObject<FOLYFOOD.Entitys.Slides> res = await slideService.CreateSlide(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("add-item-slide")]
        public async Task<IActionResult> PostItemSlide([FromBody] SildeItemRequest value)
        {
            RetunObject<FOLYFOOD.Entitys.Slides> res = await slideService.CreateItemSlide(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<SildeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SildeController>/5
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<FOLYFOOD.Entitys.Slides> res = await slideService.DeleteSlide(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
