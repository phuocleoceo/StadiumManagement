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
                UserName = c.Account.UserName
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
                //UserName = c.Account.UserName
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
            Save();
        }

        public void DeleteAccountInformation(int id)
        {
            Remove(id);
            Save();
        }

        public List<CBBItem> LoadComboBox()
        {
            AccountRepository ar = new AccountRepository();
            List<Account> listAC = ar.GetAll().ToList();
            List<CBBItem> list = new List<CBBItem>();
            foreach(Account ac in listAC)
            {
                list.Add(new CBBItem
                {
                    Value=ac.Id,
                    Text=ac.UserName
                });
            }
            return list;
        }
    }
}
