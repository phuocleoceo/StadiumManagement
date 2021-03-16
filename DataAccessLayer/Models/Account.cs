using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Enums;

namespace DataAccessLayer.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public Role Role { get; set; }
    }
}
