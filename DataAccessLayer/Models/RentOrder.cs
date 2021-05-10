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

        public double Total { get; set; }

        public int Stadium_Id { get; set; }
        [ForeignKey(nameof(Stadium_Id))]
        public virtual Stadium Stadium { get; set; }

        public int Bill_Id { get; set; }
        [ForeignKey(nameof(Bill_Id))]
        public virtual Bill Bill { get; set; }
    }
}
