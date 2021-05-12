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
    public class StatisticRepository : Repository<Bill>
    {
        public List<BillVM> GetBillHistory()
        {
            List<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased);
            List<BillVM> listVM = new List<BillVM>();
            foreach (Bill s in list)
            {
                listVM.Add(mapper.Map<BillVM>(s));
            }
            return listVM;
        }

        public void GetBillInformation(int Bill_Id, out BillVM _bvm, out List<RentOrderVM> _rovm, out List<ServiceOrderVM> _sovm)
        {
            Bill bvm = GetById(Bill_Id);
            _bvm = mapper.Map<BillVM>(bvm);

            List<RentOrder> listRO = bvm.RentOrders;
            _rovm = new List<RentOrderVM>();
            foreach (RentOrder ro in listRO)
            {
                _rovm.Add(mapper.Map<RentOrderVM>(ro));
            }

            List<ServiceOrder> listSO = bvm.ServiceOrders;
            _sovm = new List<ServiceOrderVM>();
            foreach (ServiceOrder so in listSO)
            {
                _sovm.Add(mapper.Map<ServiceOrderVM>(so));
            }
        }
    }
}
