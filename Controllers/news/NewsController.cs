using CloudinaryDotNet;
using FOLYFOOD.Dto;
using FOLYFOOD.Dto.NewsDto;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services.Info;
using FOLYFOOD.Services.News;
using FOLYFOOD.Services.product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.news
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private protected NewsServicer newsServicer;

        public NewsController()
        {
            newsServicer = new NewsServicer();
        }
        // GET: api/<NewsController>
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int pageSize = 10)
        {
            IQueryable<News> data = await newsServicer.GetNews();

            var res = PaginationHelper.GetPagedData<News>(data, page, pageSize);
            RetunObject<PagedResult<News>> dataNews = new RetunObject<PagedResult<News>>()
            {
                data = res,
                mess = res.Data.Count() > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(dataNews);
        }

        // GET api/<NewsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetailNews(int id)
        {
            RetunObject<News> res = await newsServicer.GetDetailNews(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // POST api/<NewsController>
        [HttpPost, Authorize(Roles = "admin")]
        public async Task<IActionResult> Post([FromForm] NewsRequest value)
        {
            RetunObject<News> res = await newsServicer.CrateNews(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<NewsController>/5
        [HttpPost("update-news/{id}")]
        public async Task<IActionResult> Put([FromForm] NewsRequest value)
        {
            RetunObject<News> res = await newsServicer.UpdateNews(value);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // DELETE api/<NewsController>/5
        [HttpPost("delete-news/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            RetunObject<News> res = await newsServicer.DeleteNews(id);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
    }
}
