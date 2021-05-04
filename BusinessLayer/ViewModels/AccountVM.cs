using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class AccountVM
    {
        public int Id { get; set; }

        [DisplayName("Tên tài khoản")]
        public string UserName { get; set; }

        [Browsable(false)]
        public string PassWord { get; set; }

        [DisplayName("Vai trò")]
        public string Role { get; set; }

        public byte[] Image { get; set; }
    }
}
