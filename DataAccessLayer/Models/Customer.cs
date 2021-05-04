using DataAccessLayer.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<Bill> Bills { get; set; }

        public byte[] Image { get; set; }
    }
}
