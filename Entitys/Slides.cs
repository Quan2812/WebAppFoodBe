using CloudinaryDotNet.Actions;
using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("slides")]
    public class Slides
    {
        public int SlidesId { get; set; }
        public string SlidesName { get; set; }
        public int IsShow { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Slides có nhiều Slide
        public ICollection<Slide> slides { get; set; }
    }
}
