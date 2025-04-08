using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FOLYFOOD.Entitys
{
    [Table("news")] // Tên bảng tin tức
    public class News
    {
        [Key]
        [Column("news_id")]
        public int NewsId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("shortDescription")]
        public string ShortDescription { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("is_show")]
        public bool IsShow { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("update_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("account_id")] // Khóa ngoại liên kết đến bảng tài khoản
        public int AccountId { get; set; }

        public Account Account { get; set; } // Khai báo khóa ngoại đến bảng tài khoản
    }
}
