using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class RentOrder
    {
        [Key]
        public int Id { get; set; }

        public double Deposit { get; set; }

        public int RentTime { get; set; }

        public Stadium Stadium { get; set; }
    }
}
