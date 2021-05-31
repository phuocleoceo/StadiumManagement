using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        public IEnumerable<CustomerVM> GetList(string Name)
        {
            IEnumerable<Customer> list = GetAll(c => c.Name.Contains(Name));
            foreach (Customer c in list)
            {
                yield return mapper.Map<CustomerVM>(c);
            }
        }

        public void AddCustomer(CustomerVM c)
        {
            if (c.Validate().Length == 0)
            {
                Customer customer = mapper.Map<Customer>(c);
                Add(customer);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateCustomer(CustomerVM c)
        {
            if (c.Validate().Length == 0)
            {
                Customer customer = GetById(c.Id);
                mapper.Map(c, customer);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void DeleteCustomer(int id)
        {
            Remove(id);
            Save();
        }
    }
}
