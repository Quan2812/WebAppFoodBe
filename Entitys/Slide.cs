using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("slide")]
    public class Slide
    {
        public int SlideId { get; set; }
        public int SlidesId { get; set; }
        public string SlideImage { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Slide thuộc về một Slides
        public Slides Slides { get; set; }
    }
}
