using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class ServiceVM
    {
        public int Id { get; set; }

        [DisplayName("Tên sân")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Đơn giá")]
        [Required(ErrorMessage = "Đơn giá không được để trống")]
        public double Price { get; set; }

        [DisplayName("Đơn vị tính")]
        [Required(ErrorMessage = "Đơn vị tính không được trống")]
        public string Unit { get; set; }

        public byte[] Image { get; set; }
    }
}
