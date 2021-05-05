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
        #region Login
        public int Authentication(string username, string password)
        {
            string passwordMD5 = password.GetMD5();
            Account account = GetFirstOrDefault(c => c.UserName == username && c.PassWord == passwordMD5);
            if (account == null) return 0;
            return account.Id;
        }
        #endregion

        #region Admin
        public List<AccountVM> GetList()
        {
            List<AccountVM> list = GetAll().Select(c => new AccountVM
            {
                Id = c.Id,
                UserName = c.UserName,
                PassWord = c.PassWord,
                Role = Enum.GetName(typeof(Role), c.Role),
                Image = c.Image
            }).ToList();
            return list;
        }
        private bool CheckUserName(string username, int id = 0)
        {
            //Mac dinh id=0 thi lay toan bo, id khac 0 thi lay nhung tai khoan khac tai khoan muon update
            List<Account> list = GetAll(c => c.Id != id);
            foreach (Account a in list)
            {
                if (a.UserName == username) return false;
            }
            return true;
        }
        public void AddAccount(AccountVM c)
        {
            if (CheckUserName(c.UserName))
            {
                Add(new Account
                {
                    UserName = c.UserName,
                    PassWord = c.PassWord.GetMD5(),
                    Role = (Role)Enum.Parse(typeof(Role), c.Role)
                });
                Save();
            }
            else throw new Exception("Tài khoản đã tồn tại !");
        }

        public void UpdateAccount(AccountVM c)
        {            
            if (CheckUserName(c.UserName, c.Id))
            {
                Account account = GetById(c.Id);
                account.UserName = c.UserName;
                account.Role = (Role)Enum.Parse(typeof(Role), c.Role);
                Save();
            }
            else throw new Exception("Tài khoản đã tồn tại !");
        }

        public void DeleteAccount(int id)
        {
            Remove(id);
            Save();
        }
        #endregion

        #region All User
        public void SaveImage(int id, byte[] img)
        {
            Account ac = GetById(id);
            ac.Image = img;
            Save();
        }

        public AccountVM GetAccountById(int id)
        {
            Account account = GetById(id);
            return new AccountVM
            {
                Id = account.Id,
                UserName = account.UserName,
                PassWord = account.PassWord,
                Role = Enum.GetName(typeof(Role), account.Role),
                Image=account.Image
            };
        }

        public bool CheckPassword(int id,string oldPW)
        {
            Account ac = GetById(id);
            if (ac.PassWord == oldPW.GetMD5()) return true;
            return false;
        }

        public void ChangePassword(int id,string newPW)
        {
            Account ac = GetById(id);
            ac.PassWord = newPW.GetMD5();
            Save();
        }
        #endregion
    }
}
