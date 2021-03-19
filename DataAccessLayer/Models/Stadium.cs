using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Stadium")]
    public class Stadium
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Status Status { get; set; }

        public double Area { get; set; }

        public string Note { get; set; }

        public List<RentOrder> RentOrders { get; set; }
    }
}
