using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class AccountVM
    {
        public int Id { get; set; }

        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Tên tài khoản không được để trống")]
        public string UserName { get; set; }

        [Browsable(false)]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string PassWord { get; set; }

        [DisplayName("Vai trò")]
        [Required(ErrorMessage = "Vai trò không được để trống")]
        public string Role { get; set; }

        public byte[] Image { get; set; }
    }
}
