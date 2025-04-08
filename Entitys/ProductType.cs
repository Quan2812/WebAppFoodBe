using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("product_type")]
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string NameProductType { get; set; }
        public string ImageTypeProduct { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một ProductType có nhiều Product
        public ICollection<Product> Products { get; set; }
    }
}
