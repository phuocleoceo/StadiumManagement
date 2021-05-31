using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

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
        public IEnumerable<AccountVM> GetList(string UserName)
        {
            IEnumerable<Account> list = GetAll(c => c.UserName.Contains(UserName));
            foreach (Account a in list)
            {
                yield return mapper.Map<AccountVM>(a);
            }
        }

        public void AddAccount(AccountVM c)
        {
            if (c.Validate().Length == 0)
            {
                Account account = mapper.Map<Account>(c);
                account.Image = null;
                Add(account);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateAccount(AccountVM c)
        {
            if (c.Validate().Length == 0)
            {
                Account account = GetById(c.Id);
                account.UserName = c.UserName;
                account.Role = (Role)Enum.Parse(typeof(Role), c.Role);
                Save();
            }
            else throw new Exception(c.Validate());
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
            return mapper.Map<AccountVM>(account);
        }

        public bool CheckPassword(int id, string oldPW)
        {
            Account ac = GetById(id);
            if (ac.PassWord == oldPW.GetMD5()) return true;
            return false;
        }

        public void ChangePassword(int id, string newPW)
        {
            Account ac = GetById(id);
            ac.PassWord = newPW.GetMD5();
            Save();
        }
        #endregion
    }
}
