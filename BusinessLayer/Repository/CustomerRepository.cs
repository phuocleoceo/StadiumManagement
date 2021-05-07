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
            Customer customer = mapper.Map<Customer>(c);
            Add(customer);
            Save();
        }

        public void UpdateCustomer(CustomerVM c)
        {
            Customer customer = GetById(c.Id);
            mapper.Map(c, customer);
            Save();
        }

        public void DeleteCustomer(int id)
        {
            Remove(id);
            Save();
        }
    }
}
