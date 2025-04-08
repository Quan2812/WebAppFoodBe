using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    public class Info
    {
        public int InfoId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public bool IsShow { get; set; }
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}
