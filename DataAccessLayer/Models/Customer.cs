using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
