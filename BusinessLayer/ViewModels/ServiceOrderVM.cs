using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class ServiceOrderVM : IValidatableObject
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int Bill_Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        public int Service_Id { get; set; }
        [DisplayName("Tên dịch vụ")]
        public string Service_Name { get; set; }
        [DisplayName("Đơn giá")]
        public double Service_Price { get; set; }
        public byte[] Service_Image { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public int Count { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Count <= 0)
                yield return new ValidationResult("Số lượng không hợp lệ");
        }
    }
}
