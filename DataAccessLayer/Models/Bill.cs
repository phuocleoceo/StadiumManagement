using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        public string BillCode { get; set; }

        public virtual List<RentOrder> RentOrders { get; set; }

        public virtual List<ServiceOrder> ServiceOrders { get; set; }

        public int Customer_Id { get; set; }
        [ForeignKey(nameof(Customer_Id))]
        public virtual Customer Customer { get; set; }

        public int Cashier_Id { get; set; }
        [ForeignKey(nameof(Cashier_Id))]
        public virtual AccountInformation Cashier { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateCheckedOut { get; set; }

        public BillStatus BillStatus { get; set; }

        public double Total { get; set; }
    }
}
