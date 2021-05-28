using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Required(ErrorMessage = "Đơn vị tính không được để trống")]
        public string Unit { get; set; }

        public byte[] Image { get; set; }
    }
}
