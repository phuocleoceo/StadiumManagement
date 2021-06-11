using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class CustomerVM
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Phải chọn giới tính")]
        public bool Gender { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }

        [DisplayName("SĐT")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        [MaxLength(10, ErrorMessage = "SĐT không được quá 10 chữ số")]
        [Phone(ErrorMessage = "SĐT phải nhập số")]
        public string PhoneNumber { get; set; }
    }
}
