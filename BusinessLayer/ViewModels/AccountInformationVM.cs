using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BusinessLayer.ViewModels
{
    public class AccountInformationVM : IValidatableObject
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Phải chọn giới tính")]
        public bool Gender { get; set; }

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh được để trống")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("SĐT")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        public string PhoneNumber { get; set; }

        [DisplayName("CMND")]
        [Required(ErrorMessage = "CMND không được để trống")]
        public string IdentityCard { get; set; }

        [DisplayName("Lương")]
        [Required(ErrorMessage = "Lương không được để trống")]
        public float Salary { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }

        [Browsable(false)]
        public int Account_Id { get; set; }

        [DisplayName("Tài khoản")]
        public string Account_Name { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            using (StadiumContext db = new StadiumContext())
            {
                // Chi xet nhung nhan vien co Id khac Id cua nhan vien dang Update
                if (db.AccountInformation.Any(c => c.Account_Id == Account_Id && c.Id != Id))
                    yield return new ValidationResult("Tài khoản đã thuộc về người khác");
            }
        }
    }
}
