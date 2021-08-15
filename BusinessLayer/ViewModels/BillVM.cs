using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BusinessLayer.ViewModels
{
    public class BillVM : IValidatableObject
    {
        public int Id { get; set; }

        [DisplayName("Mã hoá đơn")]
        [Required(ErrorMessage = "Mã hoá đơn không được để trống")]
        [MinLength(6, ErrorMessage = "BillCode phải dài 6 kí tự")]
        [MaxLength(6,ErrorMessage ="BillCode phải dài 6 kí tự")]
        public string BillCode { get; set; }

        [Browsable(false)]
        public int Customer_Id { get; set; }
        [DisplayName("Tên khách hàng")]
        public string Customer_Name { get; set; }
        [DisplayName("SĐT")]
        public string Customer_Phone { get; set; }

        [Browsable(false)]
        public int Cashier_Id { get; set; }
        [DisplayName("Tên thu ngân")]
        public string Cashier_Name { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Ngày thanh toán")]
        public DateTime? DateCheckedOut { get; set; }

        [DisplayName("Đã cọc")]
        public double Deposit { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            using (StadiumContext db = new StadiumContext())
            {
                if (db.Bills.Any(c => c.BillCode == BillCode))
                    yield return new ValidationResult("Mã BillCode không được trùng");
            }
        }
    }
}
