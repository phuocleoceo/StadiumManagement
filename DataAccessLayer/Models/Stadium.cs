using DataAccessLayer.Enums;
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

        public StadiumStatus Status { get; set; }

        public string Area { get; set; }

        public string Note { get; set; }

        public bool isDeleted { get; set; }

        public virtual List<RentOrder> RentOrders { get; set; }

        public byte[] Image { get; set; }
    }
}
