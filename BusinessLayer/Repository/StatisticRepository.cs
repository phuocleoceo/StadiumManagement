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
        #region Thong Ke Bill
        public List<BillVM> GetBillHistory(DateTime? _fromDate = null, DateTime? _toDate = null)
        {
            List<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased);
            if (_fromDate != null && _toDate != null)
            {
                list = list.Where(c => c.DateCheckedOut.Value.Date >= _fromDate.Value.Date
                                    && c.DateCheckedOut.Value.Date <= _toDate.Value.Date).ToList();
            }
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
        #endregion

        #region Thong Ke So Lieu   

        public void StatisticMonthAndToday(out int _billMonth, out int _billToday,
                                    out int _cusMonth, out int _cusToday, out double _saleMonth, out double _saleToday)
        {
            //Hoa don thang nay
            List<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month);
            _billMonth = listBill.Count;
            _billToday = 0;
            _saleMonth = 0;
            _saleToday = 0;
            foreach (Bill b in listBill)
            {
                _saleMonth += b.Total;
                if (b.DateCheckedOut.Value.Day == DateTime.Now.Day)
                {
                    _billToday++;
                    _saleToday += b.Total;
                }
            }
            _cusMonth = listBill.GroupBy(c => c.Customer_Id).Count();
            _cusToday = listBill.Where(c => c.DateCheckedOut.Value.Day == DateTime.Now.Day)
                                .GroupBy(c => c.Customer_Id).Count();
        }
        #endregion
    }
}
