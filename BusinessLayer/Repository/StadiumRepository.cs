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
    public class StadiumRepository : Repository<Stadium>
    {
        public List<StadiumVM> GetList()
        {
            List<Stadium> list = GetAll(c => c.isDeleted == false);
            List<StadiumVM> listVM = new List<StadiumVM>();
            foreach (Stadium s in list)
            {
                listVM.Add(mapper.Map<StadiumVM>(s));
            }
            return listVM;
        }

        public void AddStadium(StadiumVM c)
        {
            if (c.Validate().Length == 0)
            {
                Stadium s = mapper.Map<Stadium>(c);
                s.isDeleted = false;
                Add(s);
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void UpdateStadium(StadiumVM c)
        {
            if (c.Validate().Length == 0)
            {
                Stadium stadium = GetById(c.Id);
                //StadiumVM khong co thuoc tinh isDeleted
                bool isDeleted = stadium.isDeleted;
                mapper.Map(c, stadium);
                stadium.isDeleted = isDeleted;
                Save();
            }
            else throw new Exception(c.Validate());
        }

        public void DeleteStadium(int id)
        {
            Stadium stadium = GetById(id);
            stadium.isDeleted = true;
            Save();
        }

        //Dat san
        public List<StadiumVM> GetListAvailable()
        {
            List<Stadium> list = GetAll(c => c.isDeleted == false && c.Rentable == true);
            List<StadiumVM> listVM = new List<StadiumVM>();
            foreach (Stadium s in list)
            {
                listVM.Add(mapper.Map<StadiumVM>(s));
            }
            return listVM;
        }
    }
}
