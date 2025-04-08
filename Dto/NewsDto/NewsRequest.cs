using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Dto.NewsDto
{
    public class NewsRequest
    {
        public int? NewsId { get; set; }

        public string ShortDescription { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public IFormFile? Image { get; set; }

        public int AccountId { get; set; }

        public bool? IsShow { get; set; }
    }
}
