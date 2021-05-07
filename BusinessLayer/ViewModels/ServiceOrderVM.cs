using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    public class ServiceOrderVM
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int Bill_Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        [Browsable(false)]
        public int Service_Id { get; set; }
        [DisplayName("Tên dịch vụ")]
        public string Service_Name { get; set; }

        [DisplayName("Số lượng")]
        public int Count { get; set; }

        [DisplayName("Tổng tiền")]
        public float Total { get; set; }
    }
}
