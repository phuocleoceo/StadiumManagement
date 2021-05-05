using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Repository
{
    public class AccountInformationRepository : Repository<AccountInformation>
    {
        #region Admin
        public List<AccountInformationVM> GetList()
        {
            List<AccountInformationVM> list = GetAll().Select(c => new AccountInformationVM
            {
                Id = c.Id,
                Name = c.Name,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                PhoneNumber = c.PhoneNumber,
                IdentityCard = c.IdentityCard,
                Salary = c.Salary,
                Address = c.Address,
                AccountName = c.Account.UserName,
                Account_Id = c.Account.Id
            }).ToList();
            return list;
        }

        public void AddAccountInformation(AccountInformationVM c)
        {
            Add(new AccountInformation
            {
                Name = c.Name,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                PhoneNumber = c.PhoneNumber,
                IdentityCard = c.IdentityCard,
                Salary = c.Salary,
                Address = c.Address,
                Account_Id = c.Account_Id,
                Account = _db.Accounts.Find(c.Account_Id)
            });
            Save();
        }

        public void UpdateAccountInformation(AccountInformationVM c)
        {
            AccountInformation ai = GetById(c.Id);
            ai.Name = c.Name;
            ai.Gender = c.Gender;
            ai.DateOfBirth = c.DateOfBirth;
            ai.PhoneNumber = c.PhoneNumber;
            ai.IdentityCard = c.IdentityCard;
            ai.Salary = c.Salary;
            ai.Address = c.Address;
            ai.Account_Id = c.Account_Id;
            ai.Account = _db.Accounts.Find(c.Account_Id);
            Save();
        }

        public void DeleteAccountInformation(int id)
        {
            Remove(id);
            Save();
        }

        public List<CBBItem> LoadComboBox()
        {
            List<Account> listAC = _db.Accounts.ToList();
            List<CBBItem> list = new List<CBBItem>();
            foreach (Account ac in listAC)
            {
                list.Add(new CBBItem
                {
                    Value = ac.Id,
                    Text = ac.UserName
                });
            }
            return list;
        }
        #endregion

        #region All User
        public AccountInformationVM GetAIByAccountId(int Account_Id)
        {
            AccountInformation ai = GetFirstOrDefault(c => c.Account_Id == Account_Id);
            if (ai == null) return null;
            return new AccountInformationVM
            {
                Id = ai.Id,
                Name = ai.Name,
                Gender = ai.Gender,
                DateOfBirth = ai.DateOfBirth,
                PhoneNumber = ai.PhoneNumber,
                IdentityCard = ai.IdentityCard,
                Salary = ai.Salary,
                Address = ai.Address,
                AccountName = ai.Account.UserName,
                Account_Id = ai.Account_Id
            };
        }
        #endregion
    }
}
