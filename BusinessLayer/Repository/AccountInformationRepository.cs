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

        public void AddAccountInformation(AccountInformationVM ai)
        {
            Add(new AccountInformation
            {
                //Id = c.Id,
                //Name = c.Name,
                //Gender = c.Gender,
                //DateOfBirth = c.DateOfBirth,
                //PhoneNumber = c.PhoneNumber,
                //IdentityCard = c.IdentityCard,
                //Salary = c.Salary,
                //Address = c.Address,
                //UserName = c.Account.UserName
            });
            Save();
        }

        //public void UpdateCustomer(CustomerVM c)
        //{
        //    Customer customer = GetById(c.Id);
        //    customer.Name = c.Name;
        //    customer.Gender = c.Gender;
        //    customer.Address = c.Address;
        //    customer.PhoneNumber = c.PhoneNumber;
        //    Save();
        //}

        //public void DeleteCustomer(int id)
        //{
        //    Remove(id);
        //    Save();
        //}
    }
}
