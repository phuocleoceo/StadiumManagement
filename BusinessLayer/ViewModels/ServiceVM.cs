using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class ServiceVM
    {
        public int Id { get; set; }

        [DisplayName("Tên sân")]
        public string Name { get; set; }

        [DisplayName("Đơn giá")]
        public double Price { get; set; }

        [DisplayName("Đơn vị tính")]
        public string Unit { get; set; }

        public byte[] Image { get; set; }
    }
}
