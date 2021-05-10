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
    public class BillRepository : Repository<Bill>
    {
        public List<BillVM> GetList()
        {
            List<Bill> list = GetAll(c => c.BillStatus == BillStatus.UnPurchased);
            List<BillVM> listVM = new List<BillVM>();
            foreach (Bill s in list)
            {
                listVM.Add(mapper.Map<BillVM>(s));
            }
            return listVM;
        }

        public void GetComboBoxCustomer(ComboBox cbb)
        {
            List<Customer> listCus = _db.Customers.ToList();
            foreach (Customer cus in listCus)
            {
                cbb.Items.Add(new CBBItem
                {
                    Value = cus.Id,
                    Text = cus.Name
                });
            }
        }

        //public double GetTotal()
        //{

        //}

        public void AddBill(BillVM bvm)
        {
            Bill b = mapper.Map<Bill>(bvm);
            b.BillStatus = BillStatus.UnPurchased;
            Add(b);
            Save();
        }
    }
}
