using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        public List<RentOrder> RentOrders { get; set; }

        public List<ServiceOrder> ServiceOrders { get; set; }

        public Customer Customer { get; set; }

        public Cashier Cashier { get; set; }

        public DateTime DateCreated { get; set; }

        public double Total { get; set; }
    }
}
