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
    public class RentOrderRepository : Repository<RentOrder>
    {
        public List<RentOrderVM> GetList(int Bill_Id)
        {
            List<RentOrder> list = GetAll(c => c.Bill_Id == Bill_Id);
            List<RentOrderVM> listVM = new List<RentOrderVM>();
            foreach (RentOrder s in list)
            {
                listVM.Add(mapper.Map<RentOrderVM>(s));
            }
            return listVM;
        }

        public void AddRentOrder(RentOrderVM rovm)
        {
            RentOrder ro = mapper.Map<RentOrder>(rovm);
            Add(ro);
            Save();
        }

        public void UpdateRentOrder(RentOrderVM rovm)
        {
            RentOrder ro = GetById(rovm.Id);
            mapper.Map(rovm, ro);
            Save();
        }

        public void DeleteRentOrder(int id)
        {
            Remove(id);
            Save();
        }

        //Validate dat san
        public string ListRentTime(int stadium_id)
        {
            // Lay list RO cua San, Chi lay nhung RO thuoc Bill chua thanh toan
            IEnumerable<RentOrder> listRO = _db.Stadiums.Find(stadium_id).RentOrders;
            listRO = listRO.Where(c => c.Bill.BillStatus == BillStatus.UnPurchased);

            StringBuilder sb = new StringBuilder();
            foreach (RentOrder ro in listRO)
            {
                sb.Append($"{ro.StartRentDate,22}  => {ro.EndRentDate,22}\n");
            }
            return sb.ToString();
        }
    }
}
