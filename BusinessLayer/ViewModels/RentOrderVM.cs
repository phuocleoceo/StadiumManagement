using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.ViewModels
{
    public class RentOrderVM
    {        
        public int Id { get; set; }

        [Browsable(false)]
        public int Bill_Id { get; set; }
        [DisplayName("Mã hoá đơn")]
        public string Bill_Code { get; set; }

        public int Stadium_Id { get; set; }
        [DisplayName("Tên sân")]
        public string Stadium_Name { get; set; }
        [DisplayName("Đơn giá")]
        public double Stadium_Price { get; set; }
        public byte[] Stadium_Image { get; set; }

        [DisplayName("Bắt đầu thuê")]
        public DateTime StartRentDate { get; set; }

        [DisplayName("Kết thúc thuê")]
        public DateTime EndRentDate { get; set; }

        [Browsable(false)]
        public double RentTime => Convert.ToInt32((EndRentDate - StartRentDate).TotalHours);

        [DisplayName("Tiền cọc")]
        public double Deposit { get; set; }

        [DisplayName("Tổng tiền")]
        public double Total { get; set; }              
    }
}
