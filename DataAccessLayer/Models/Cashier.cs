using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Cashier
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string IdentityCard { get; set; }

        public float Salary { get; set; }

        public string Note { get; set; }

        public Account Account { get; set; }

        public List<Bill> Bills { get; set; }
    }
}
