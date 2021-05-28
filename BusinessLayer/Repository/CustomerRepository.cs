using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        public List<CustomerVM> GetList()
        {
            List<Customer> list = GetAll();
            List<CustomerVM> listVM = new List<CustomerVM>();
            foreach(Customer c in list)
            {
                listVM.Add(mapper.Map<CustomerVM>(c));
            }
            return listVM;
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
