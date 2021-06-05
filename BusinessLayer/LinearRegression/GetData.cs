using BusinessLayer.Repository;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.LinearRegression
{
    public class GetData : Repository<Bill>
    {
        // Số khách trung bình mỗi ngày(thứ) trong tuần
        public IEnumerable<double> GetAverageCustomer()
        {
            IEnumerable<Bill> listBill = GetAll(c => c.BillStatus == BillStatus.Purchased);
            for (int i = 0; i < 7; i++)
            {
                IEnumerable<Bill> listBillPerDOW = listBill.Where(c => c.DateCheckedOut.Value.DayOfWeek
                                                          == (DayOfWeek)i);                //0 : Sunday
                int totalRecord = listBillPerDOW.GroupBy(c => c.BillCode).Count();
                int totalDay = listBillPerDOW.GroupBy(c => c.DateCheckedOut.Value.Date).Count();
                if (totalDay == 0) totalDay = 1; //totalRecord va totalDay deu bang 0
                // Cùng ngày nhưng khác giờ thì tính thành 2 => Chỉ lấy Date
                //int totalDay = listBillPerDOW.Select(c => c.c.DateCheckedOut.Value.Date).Distinct().Count();
                yield return (double)totalRecord / totalDay;
            }
        }

        // Trong mỗi ngày, có bao nhiêu khách và doanh thu bao nhiêu
        public IEnumerable<PricePerCustomer> GetPricePerCustomer()
        {
            return GetAll(c => c.BillStatus == BillStatus.Purchased)
            .GroupBy(c => c.DateCheckedOut.Value.Date)
            .Select(c => new PricePerCustomer
            {
                TotalCus = c.Count(),
                TotalPrice = c.Sum(x => x.Total)
            });
        }
    }

    public class PricePerCustomer
    {
        public int TotalCus { get; set; }
        public double TotalPrice { get; set; }
    }
}
