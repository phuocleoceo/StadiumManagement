using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class ServiceOrder
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        public float Total { get; set; }

        public Service Service { get; set; }

        public Bill Bill { get; set; }
    }
}
