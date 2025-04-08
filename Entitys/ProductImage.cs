using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("product_image")]
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string Title { get; set; }
        public string ImageProduct { get; set; }
        public int ProductId { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một ProductImage thuộc về một Product
        public Product Product { get; set; }
    }
}
