using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.ViewModels
{
    public class ServiceOrderVM
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int Bill_Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        public int Service_Id { get; set; }
        [DisplayName("Tên dịch vụ")]
        public string Service_Name { get; set; }
        public double Service_Price { get; set; }
        public byte[] Service_Image { get; set; }

        [DisplayName("Số lượng")]
        public int Count { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }
    }
}
