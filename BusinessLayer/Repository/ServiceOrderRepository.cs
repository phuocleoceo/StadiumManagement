using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using DataAccessLayer;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;

namespace BusinessLayer.Repository
{
    public class ServiceOrderRepository : Repository<ServiceOrder>
    {
        public List<ServiceOrderVM> GetList(int Bill_Id, string ServiceName)
        {
            List<ServiceOrder> list = GetAll(c => c.Bill_Id == Bill_Id && c.Service.Name.Contains(ServiceName));
            List<ServiceOrderVM> listVM = new List<ServiceOrderVM>();
            foreach (ServiceOrder s in list)
            {
                listVM.Add(mapper.Map<ServiceOrderVM>(s));
            }
            return listVM;
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
