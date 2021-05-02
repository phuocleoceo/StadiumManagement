using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class CustomerVM
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        public bool Gender { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("SĐT")]
        public string PhoneNumber { get; set; }
    }
}
