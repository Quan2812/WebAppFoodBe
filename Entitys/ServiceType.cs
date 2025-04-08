using System.ComponentModel.DataAnnotations.Schema;

namespace FOLYFOOD.Entitys
{
    [Table("sevicer_type")]
    public class ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ImageTypeService { get; set; }
        public string Describe { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Mối quan hệ: Một ServiceType có nhiều Service
        public ICollection<Service> Services { get; set; }
    }
}
