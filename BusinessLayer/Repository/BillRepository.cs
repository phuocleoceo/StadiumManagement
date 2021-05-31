using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessLayer.Repository
{
    public class BillRepository : Repository<Bill>
    {
        public IEnumerable<BillVM> GetList(string BillCode)
        {
            IEnumerable<Bill> list = GetAll(c => c.BillStatus == BillStatus.UnPurchased
                                            && c.BillCode.Contains(BillCode));
            foreach (Bill s in list)
            {
                yield return mapper.Map<BillVM>(s);
            }
        }

        public void GetComboBoxCustomer(ComboBox cbb)
        {
            IEnumerable<Customer> listCus = _db.Customers;
            foreach (Customer cus in listCus)
            {
                cbb.Items.Add(new CBBItem
                {
                    Value = cus.Id,
                    Text = cus.Name
                });
            }
        }

        public void SetTotal(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            // Tong tien
            double _total = 0;
            foreach (RentOrder ro in b.RentOrders) _total += ro.Total;
            foreach (ServiceOrder so in b.ServiceOrders) _total += so.Total;
            b.Total = _total;
            // Tien coc
            double _deposit = 0;
            foreach (RentOrder ro in b.RentOrders) _deposit += ro.Deposit;
            b.Deposit = _deposit;
            Save();
        }

        public void AddBill(BillVM bvm)
        {
            if (bvm.Validate().Length == 0)
            {
                Bill b = mapper.Map<Bill>(bvm);
                b.BillStatus = BillStatus.UnPurchased;
                Add(b);
                Save();
            }
            else throw new Exception(bvm.Validate());
        }

        public void PurchaseBill(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            b.BillStatus = BillStatus.Purchased;
            b.DateCheckedOut = DateTime.Now;
            Save();
        }

        public void DeleteBill(int Bill_Id)
        {
            Remove(Bill_Id);
            Save();
        }

        public string GetContentPrint(int Bill_Id)
        {
            Bill b = GetById(Bill_Id);
            StringBuilder content = new StringBuilder();
            //Chao mung
            content.Append("\t\t\t       He thong cho thue san the thao chuyen nghiep PNHD\n");
            content.Append("\t\t\t\tDia chi : Truong Dai Hoc Bach Khoa Da Nang\n\n");
            content.Append("\t\t\t\t\tHoa don thanh toan\n");
            content.Append($"\t\t\t\t\tMa so : {b.BillCode}\n\n");
            content.Append($"\t\t\t\t\tNgay tao lap : {b.DateCreated}\n");
            content.Append($"\t\t\t\t\tNgay thanh toan : {b.DateCheckedOut}\n");
            content.Append($"\t\t\t\t\tKhach hang : {b.Customer.Name}\n");
            content.Append($"\t\t\t\t\tSDT : {b.Customer.PhoneNumber}\n");
            content.Append($"\t\t\t\t\tThu ngan : {b.Cashier.Name}\n");
            //Thue san
            content.Append("\n_______________________________________San the thao thue :______________________________________\n\n");
            content.Append($"{"Ten san",15}\t\t{"Don gia",7}\t{"Bat dau thue",22}\t{"Ket thuc thue",22}\t{"Tong cong",9}\t{"Tien coc",8}\n");
            foreach (RentOrder ro in b.RentOrders)
            {
                content.Append($"{ro.Stadium.Name,15}\t{ro.Stadium.Price,7}\t{ro.StartRentDate,22}\t{ro.EndRentDate,22}\t{ro.Total,9}\t{ro.Deposit,8}\n");
            }
            //Dich vu
            content.Append("\n_______________________________________Su dung dich vu  :_______________________________________\n\n");
            content.Append($"\t\t{"Ten dich vu",15}\t\t{"Don gia",7}\t\t{"So luong",8}\t{"Tong cong",9}\n");
            foreach (ServiceOrder so in b.ServiceOrders)
            {
                content.Append($"\t\t{so.Service.Name,15}\t\t{so.Service.Price,7}\t\t{so.Count,8}\t\t{so.Total,9}\n");
            }
            //Tong ket
            content.Append("\n_______________________________________Tong thanh toan :________________________________________\n\n");
            content.Append($"\t\t\t\t\t>> Tong cong : {b.Total}\n");
            content.Append($"\t\t\t\t\t>> Tien coc  : {b.Deposit}\n");
            content.Append($"\t\t\t\t\t>> Phai tra  : {b.Total - b.Deposit}\n");
            content.Append("\n\t\t\t\t\tCam on quy khach !");

            return content.ToString();
        }
    }
}
