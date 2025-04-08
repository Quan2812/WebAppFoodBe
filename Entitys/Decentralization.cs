using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FOLYFOOD.Entitys
{
    [Table("decentralization")]
    public class Decentralization
    {
        [Key]
        [Column("decentralization_id")]
        public int DecentralizationId { get; set; }

        [Column("Authority_name")]
        public string AuthorityName { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("update_at")]
        public DateTime UpdateAt { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
