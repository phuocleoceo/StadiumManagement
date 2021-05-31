using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Repository
{
    public class StatisticRepository : Repository<Bill>
    {
        #region Thong Ke Bill
        public List<BillVM> GetBillHistory(string CustomerName, DateTime? _fromDate = null, DateTime? _toDate = null)
        {
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased
                                        && c.Customer.Name.Contains(CustomerName));
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

        public void GetBillInformation(int Bill_Id, out BillVM _bvm, out List<RentOrderVM> _rovm,
                                                                    out List<ServiceOrderVM> _sovm)
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
            //Hoa don thang nay, co DateCheckedOut nghia la da thanh toan
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);
            _billMonth = listBill.Count();
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

        public void StatisticSalePerMonth(out double[] _doanhThuThang)
        {
            _doanhThuThang = new double[13];
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.Purchased &&
                                            c.DateCheckedOut.Value.Year == DateTime.Now.Year);
            for (int i = 1; i <= 12; i++)
            {
                _doanhThuThang[i] += list.Where(c => c.DateCheckedOut.Value.Month == i)
                                            .Sum(c => c.Total);
            }
        }

        public List<Frequency> StatisticStadium()
        {
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);
            List<RentOrder> listAllRO = new List<RentOrder>();
            foreach (Bill b in listBill)
            {
                listAllRO.AddRange(b.RentOrders);
            }
            List<Frequency> listFre = listAllRO.GroupBy(c => c.Stadium.Name).Select(c => new Frequency
            {
                Name = c.First().Stadium.Name,
                Count = c.Sum(x => Convert.ToInt32((x.EndRentDate - x.StartRentDate).TotalHours))
            }).ToList();
            return listFre;
        }

        public List<Frequency> StatisticService()
        {
            IEnumerable<Bill> listBill = GetAll(c => c.DateCheckedOut.Value.Month == DateTime.Now.Month
                                            && c.DateCheckedOut.Value.Year == DateTime.Now.Year);
            List<ServiceOrder> listAllSO = new List<ServiceOrder>();
            foreach (Bill b in listBill)
            {
                listAllSO.AddRange(b.ServiceOrders);
            }
            List<Frequency> listFre = listAllSO.GroupBy(c => c.Service.Name).Select(c => new Frequency
            {
                Name = c.First().Service.Name,
                Count = c.Sum(x => x.Count)
            }).ToList();
            return listFre;
        }
        #endregion
    }

    public class Frequency
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
