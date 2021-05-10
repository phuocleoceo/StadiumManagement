using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class ServiceOrder
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        public double Total { get; set; }

        public int Service_Id { get; set; }
        [ForeignKey(nameof(Service_Id))]
        public virtual Service Service { get; set; }

        public int Bill_Id { get; set; }
        [ForeignKey(nameof(Bill_Id))]
        public virtual Bill Bill { get; set; }
    }
}
