using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class ServiceOrderRepository : Repository<ServiceOrder>
    {
        public IEnumerable<ServiceOrderVM> GetList(int Bill_Id, string ServiceName)
        {
            IEnumerable<ServiceOrder> list = GetAll(c => c.Bill_Id == Bill_Id
                                                && c.Service.Name.Contains(ServiceName));
            foreach (ServiceOrder s in list)
            {
                yield return mapper.Map<ServiceOrderVM>(s);
            }
        }

        public void AddServiceOrder(ServiceOrderVM sovm)
        {
            if (sovm.Validate().Length == 0)
            {
                ServiceOrder so = mapper.Map<ServiceOrder>(sovm);
                Add(so);
                Save();
            }
            else throw new Exception(sovm.Validate());
        }

        public void UpdateServiceOrder(ServiceOrderVM sovm)
        {
            if (sovm.Validate().Length == 0)
            {
                ServiceOrder so = GetById(sovm.Id);
                mapper.Map(sovm, so);
                Save();
            }
            else throw new Exception(sovm.Validate());
        }

        public void DeleteServiceOrder(int id)
        {
            Remove(id);
            Save();
        }
    }
}
