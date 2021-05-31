using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class StadiumVM
    {
        public int Id { get; set; }

        [DisplayName("Tên sân")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Đơn giá")]
        [Required(ErrorMessage = "Đơn giá không được để trống")]
        public double Price { get; set; }

        [DisplayName("Cho thuê")]
        [Required(ErrorMessage = "Phải xác định sân cho thuê hay không")]
        public bool Rentable { get; set; }

        [DisplayName("Diện tích")]
        [Required(ErrorMessage = "Diện tích không được để trống")]
        public string Area { get; set; }

        [DisplayName("Ghi chú")]
        public string Note { get; set; }

        public byte[] Image { get; set; }
    }
}
