using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Enums;

namespace DataAccessLayer.Models
{
    [Table("TAIKHOAN")]
    public class TAIKHOAN
    {
        [Key]
        public string MaNV { get; set; }

        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public Role VaiTro { get; set; }
    }
}
