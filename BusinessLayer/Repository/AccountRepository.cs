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
        public bool CheckLogin(string username, string password)
        {
            List<Account> list = GetAll();
            foreach (Account i in list)
            {
                if (i.UserName == username && i.PassWord == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
