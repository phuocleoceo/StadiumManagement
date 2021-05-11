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
    public class RentOrderRepository:Repository<RentOrder>
    {
        public List<RentOrderVM> GetList()
        {
            List<RentOrder> list = GetAll();
            List<RentOrderVM> listVM = new List<RentOrderVM>();
            foreach (RentOrder s in list)
            {
                listVM.Add(mapper.Map<RentOrderVM>(s));
            }
            return listVM;
        }

        public void AddRentOrder(RentOrderVM rovm) 
        {

        }

        public void UpdateRentOrder(RentOrderVM rovm)
        {

        }

        public void DeleteRentOrder(int id)
        {
            Remove(id);
            Save();
        }
    }
}
