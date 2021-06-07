using DataAccessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BusinessLayer.ViewModels
{
    public class AccountVM : IValidatableObject
    {
        public int Id { get; set; }

        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Tên tài khoản không được để trống")]
        public string UserName { get; set; }

        [Browsable(false)]
        public string PassWord { get; set; }

        [DisplayName("Vai trò")]
        [Required(ErrorMessage = "Vai trò không được để trống")]
        public string Role { get; set; }

        public byte[] Image { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            using (StadiumContext db = new StadiumContext())
            {
                //Id chua co nghia la ta dang Add
                if (!db.Accounts.Any(c => c.Id == Id) && string.IsNullOrWhiteSpace(PassWord))
                    yield return new ValidationResult("Mật khẩu không được để trống");
                //Neu ton tai Id trung voi Id hien tai thi nghia la ta dang Update => ko loi
                if (db.Accounts.Any(c => c.UserName == UserName && c.Id != Id))
                    yield return new ValidationResult("Tên tài khoản không được trùng");
            }
        }
    }
}
