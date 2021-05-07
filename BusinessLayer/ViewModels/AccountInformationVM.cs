using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class AccountInformationVM
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        public bool Gender { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("SĐT")]
        public string PhoneNumber { get; set; }

        [DisplayName("CMND")]
        public string IdentityCard { get; set; }

        [DisplayName("Lương")]
        public float Salary { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [Browsable(false)]
        public int Account_Id { get; set; }

        [DisplayName("Tài khoản")]
        public string Account_Name { get; set; }
    }
}
