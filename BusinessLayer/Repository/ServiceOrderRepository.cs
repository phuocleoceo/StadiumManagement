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
        public List<ServiceOrderVM> GetList()
        {
            List<ServiceOrder> list = GetAll();
            List<ServiceOrderVM> listVM = new List<ServiceOrderVM>();
            foreach (ServiceOrder s in list)
            {
                listVM.Add(mapper.Map<ServiceOrderVM>(s));
            }
            return listVM;
        }
    }
}
