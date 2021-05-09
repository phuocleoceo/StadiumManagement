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
        //Load danh sach Bill
        public void LoadComboBoxBill(ComboBox cbb)
        {
            List<Bill> listBill = _db.Bills.Where(c => c.BillStatus == BillStatus.UnPurchased).ToList();
            foreach (Bill b in listBill)
            {
                cbb.Items.Add(new CBBItem
                {
                    Value = b.Id,
                    Text = $"{b.BillCode} | {b.Customer.Name}"
                });
            }
        }
    }
}
