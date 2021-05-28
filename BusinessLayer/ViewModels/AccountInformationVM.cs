using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class AccountInformationVM
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
        [Required(ErrorMessage = "Số điện thoại được để trống")]
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
    }
}
