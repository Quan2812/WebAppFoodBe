using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("product")]
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string NameProduct { get; set; }
        public double Price { get; set; }
        public string AvartarImageProduct { get; set; }
        public string Title { get; set; }
        [NotMapped] // Đánh dấu trường này để không ánh xạ vào cơ sở dữ liệu
        public int QuantityOrder { get; set; }
        public int number_of_views { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một Product thuộc về một ProductType
        public ProductType ProductType { get; set; }

        // Mối quan hệ: Một Product có nhiều ProductImage
        public ICollection<ProductImage> ProductImages { get; set; }

        // Mối quan hệ: Một Product có nhiều ProductReview
        public ICollection<ProductReview> ProductReviews { get; set; }

        // Mối quan hệ: Một Product có nhiều OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
