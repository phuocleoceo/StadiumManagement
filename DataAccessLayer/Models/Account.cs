using DataAccessLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public Role Role { get; set; }

        public byte[] Image { get; set; }
    }
}
