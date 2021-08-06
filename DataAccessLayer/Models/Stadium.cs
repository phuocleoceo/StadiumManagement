using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    [Table("Stadium")]
    public class Stadium
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Rentable { get; set; }

        public string Area { get; set; }

        public string Note { get; set; }

        public bool isDeleted { get; set; }

        public virtual HashSet<RentOrder> RentOrders { get; set; }

        public byte[] Image { get; set; }
    }
}
