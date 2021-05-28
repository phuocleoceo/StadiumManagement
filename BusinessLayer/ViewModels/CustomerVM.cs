using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.ViewModels
{
    public class CustomerVM
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage ="Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage ="Phải chọn giới tính")]
        public bool Gender { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage ="Địa chỉ không được để trống")]
        public string Address { get; set; }

        [DisplayName("SĐT")]
        [Required(ErrorMessage ="Số điện thoại không được để trống")]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
    }
}
