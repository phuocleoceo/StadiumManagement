using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ViewModels;
using DataAccessLayer;
using DataAccessLayer.Enums;
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

        public bool Authorization(string username, string password, out string displayName)
        {
            string passwordMD5 = password.GetMD5();
            Account account = GetFirstOrDefault(c => c.UserName == username && c.PassWord == passwordMD5);
            displayName = account.UserName;
            Role role = account.Role;
            if (role == Role.Admin) return true;
            else return false;
        }

        public List<AccountVM> GetList()
        {
            List<AccountVM> list = GetAll().Select(c => new AccountVM
            {
                Id = c.Id,
                UserName = c.UserName,
                PassWord = c.PassWord,
                Role = Enum.GetName(typeof(Role), c.Role)
            }).ToList();
            return list;
        }

        public void AddAccount(AccountVM c)
        {
            Add(new Account
            {
                UserName = c.UserName,
                PassWord = c.PassWord.GetMD5(),
                Role = (Role)Enum.Parse(typeof(Role), c.Role)
            });
            Save();
        }

        public void UpdateAccount(AccountVM c)
        {
            Account account = GetById(c.Id);
            account.UserName = c.UserName;
            account.Role = (Role)Enum.Parse(typeof(Role), c.Role);
            Save();
        }

        public void DeleteAccount(int id)
        {
            Remove(id);
            Save();
        }
    }
}
