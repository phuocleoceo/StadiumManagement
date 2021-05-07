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
    public class ServiceRepository : Repository<Service>
    {
        public List<ServiceVM> GetList()
        {
            List<Service> list = GetAll(c => c.isDeleted == false);
            List<ServiceVM> listVM = new List<ServiceVM>();
            foreach (Service s in list)
            {
                listVM.Add(mapper.Map<ServiceVM>(s));
            }
            return listVM;
        }

        public void AddService(ServiceVM c)
        {
            Service s = mapper.Map<Service>(c);
            s.isDeleted = false;
            Add(s);
            Save();
        }

        public void UpdateService(ServiceVM c)
        {
            Service service = GetById(c.Id);
            service.Name = c.Name;
            service.Price = c.Price;
            service.Unit = c.Unit;
            service.Image = c.Image;
            Save();
        }

        public void DeleteService(int id)
        {
            Service service = GetById(id);
            service.isDeleted = true;
            Save();
        }
    }
}
