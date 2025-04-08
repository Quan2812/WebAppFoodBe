using FOLYFOOD.Dto;
using FOLYFOOD.Dto.Contact;
using FOLYFOOD.Dto.NewFolder;
using FOLYFOOD.Entitys;
using FOLYFOOD.Hellers.Pagination;
using FOLYFOOD.Services.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FOLYFOOD.Controllers.contact
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private protected ContactService contactService;

        public ContactController() { 
            contactService = new ContactService();
        }
        // GET: api/<ContactController>
        [HttpGet, Authorize(Roles = "staff, admin")]
        public IActionResult Get(int page = 1, int pageSize = 10)
        {
            var data = contactService.getDataContact();
            var res = PaginationHelper.GetPagedData(data.data, page, pageSize);
            RetunObject<PagedResult<Contact>> test = new RetunObject<PagedResult<Contact>>()
            {
                data = res,
                mess = res.Data.Count()  > 0 ? "đã lấy được dữ liệu" : "không có data",
                statusCode = 200,
            };
            return Ok(test);
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}"), Authorize(Roles = "staff, admin")]
        public IActionResult Get(int id)
        {
            return Ok(contactService.GetOneContact(id));
        }

        // POST api/<ContactController>
        [HttpPost]
        public IActionResult Post([FromBody] ContactDto data)
        {
            RetunObject<Contact> res = contactService.addContact(data);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPost("reply-contact"), Authorize(Roles = "staff, admin")]
        public IActionResult replyContact(ContactReplyRequets contactReplyRequets)
        {
            RetunObject<Contact> res = contactService.replyToContact(contactReplyRequets.email, contactReplyRequets.mess);
            if (res.errorOccurred)
            {
                return NotFound(res);
            }
            return Ok(res);
        }

        // PUT api/<ContactController>/5
        [HttpPost("update/{id}"), Authorize(Roles = "staff, admin")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpGet("delete/{id}")]
        public void Delete(int id)
        {
        }
    }
}
