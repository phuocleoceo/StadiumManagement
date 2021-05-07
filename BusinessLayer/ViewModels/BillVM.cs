using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    public class BillVM
    {
        public int Id { get; set; }

        [DisplayName("Mã hoá đơn")]
        public string BillCode { get; set; }

        public int Customer_Id { get; set; }
        [DisplayName("Tên khách hàng")]
        public string Customer_Name { get; set; }

        public int Cashier_Id { get; set; }
        [DisplayName("Tên thu ngân")]
        public string Cashier_Name { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Ngày thanh toán")]
        public DateTime DateCheckedOut { get; set; }

        [DisplayName("Trạng thái")]
        public string BillStatus { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }
    }
}
