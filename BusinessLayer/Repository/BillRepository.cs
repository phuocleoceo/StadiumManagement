using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ViewModels;
using DataAccessLayer;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;

namespace BusinessLayer.Repository
{
    public class BillRepository:Repository<Bill>
    {
        public List<BillVM> GetList()
        {
            List<Bill> list = GetAll();
            List<BillVM> listVM = new List<BillVM>();
            foreach (Bill s in list)
            {
                listVM.Add(mapper.Map<BillVM>(s));
            }
            return listVM;
        }
    }
}
