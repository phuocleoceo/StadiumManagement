using BusinessLayer.ViewModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Repository
{
    public class ServiceRepository : Repository<Service>
    {
        public IEnumerable<ServiceVM> GetList(string ServiceName)
        {
            IEnumerable<Service> list = GetAll(c => c.isDeleted == false 
                                            && c.Name.Contains(ServiceName));
            foreach (Service s in list)
            {
                yield return mapper.Map<ServiceVM>(s);
            }
        }

        public void AddService(ServiceVM c)
        {
            if (c.Validate().Length == 0)
            {
                Service s = mapper.Map<Service>(c);
                s.isDeleted = false;
                Add(s);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateService(ServiceVM c)
        {
            if (c.Validate().Length == 0)
            {
                Service service = GetById(c.Id);
                mapper.Map(c, service);
                service.isDeleted = false;
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void DeleteService(int id)
        {
            Service service = GetById(id);
            service.isDeleted = true;
            Save();
        }
    }
}
