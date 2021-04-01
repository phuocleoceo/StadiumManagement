using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class RentOrder
    {
        [Key]
        public int Id { get; set; }

        public double Deposit { get; set; }

        public DateTime StartRentDate { get; set; }

        public DateTime EndRentDate { get; set; }

        [NotMapped]
        public double RentTime => (EndRentDate - StartRentDate).TotalHours;

        public float Total { get; set; }

        public Stadium Stadium { get; set; }

        public Bill Bill { get; set; }
    }
}
