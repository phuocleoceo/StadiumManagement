using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        public List<CustomerVM> GetList()
        {
            List<CustomerVM> list = GetAll().Select(c => new CustomerVM
            {
                Id = c.Id,
                Name = c.Name,
                Gender = c.Gender,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber
            }).ToList();
            return list;
        }

        public void AddCustomer(CustomerVM c)
        {
            Add(new Customer
            {
                Name = c.Name,
                Gender = c.Gender,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber
            });
            Save();
        }

        public void UpdateCustomer(CustomerVM c)
        {
            Customer customer = GetById(c.Id);
            customer.Name = c.Name;
            customer.Gender = c.Gender;
            customer.Address = c.Address;
            customer.PhoneNumber = c.PhoneNumber;
            Save();
        }

        public void DeleteCustomer(int id)
        {
            Remove(id);
            Save();
        }
    }
}
