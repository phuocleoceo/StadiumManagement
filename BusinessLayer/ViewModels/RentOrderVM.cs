using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class RentOrderVM : IValidatableObject
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int Bill_Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        public int Stadium_Id { get; set; }
        [DisplayName("Tên sân")]
        public string Stadium_Name { get; set; }
        [DisplayName("Đơn giá")]
        public double Stadium_Price { get; set; }
        public byte[] Stadium_Image { get; set; }

        [DisplayName("Bắt đầu thuê")]
        [Required(ErrorMessage = "Giờ thuê không được để trống")]
        public DateTime StartRentDate { get; set; }

        [DisplayName("Kết thúc thuê")]
        [Required(ErrorMessage = "Giờ trả không được để trống")]
        public DateTime EndRentDate { get; set; }

        [Browsable(false)]
        public double RentTime => Utility.RentTime(StartRentDate,EndRentDate);

        [DisplayName("Tiền cọc")]
        [Required(ErrorMessage = "Tiền cọc không được để trống")]
        public double Deposit { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartRentDate <= DateTime.Now)
                yield return new ValidationResult("Giờ thuê không được sớm hơn hiện tại");
            if (EndRentDate <= StartRentDate)
                yield return new ValidationResult("Giờ trả không được sớm hơn giờ thuê");
        }
    }
}
