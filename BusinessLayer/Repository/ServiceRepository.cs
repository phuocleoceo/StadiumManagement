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
            List<ServiceVM> list = GetAll(c => c.isDeleted == false).Select(c => new ServiceVM
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price,
                Unit = c.Unit,
                Image=c.Image
            }).ToList();
            return list;
        }

        public void AddService(ServiceVM c)
        {
            Add(new Service
            {
                Name = c.Name,
                Price = c.Price,
                Unit = c.Unit,
                isDeleted = false,
                Image=c.Image
            });
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

        public byte[] GetImage(int id)
        {
            return GetFirstOrDefault(c => c.Id == id).Image;
        }
    }
}
