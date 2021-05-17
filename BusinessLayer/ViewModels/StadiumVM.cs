using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class StadiumVM
    {
        public int Id { get; set; }

        [DisplayName("Tên sân")]
        public string Name { get; set; }

        [DisplayName("Đơn giá")]
        public double Price { get; set; }

        [DisplayName("Cho thuê được")]
        public bool Rentable { get; set; }

        [DisplayName("Diện tích")]
        public string Area { get; set; }

        [DisplayName("Ghi chú")]
        public string Note { get; set; }

        public byte[] Image { get; set; }
    }
}
