using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessLayer.Repository
{
    public class AccountRepository : Repository<Account>
    {
        public bool Authentication(string username, string password)
        {
            string passwordMD5 = password.GetMD5();
            return _db.Accounts.Any(c => c.UserName == username && c.PassWord == passwordMD5);
        }
    }
}
