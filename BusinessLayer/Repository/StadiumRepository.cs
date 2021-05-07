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
            Stadium s = mapper.Map<Stadium>(c);
            s.isDeleted = false;
            s.Status = StadiumStatus.Free;
            Add(s);
            Save();
        }

        public void UpdateStadium(StadiumVM c)
        {
            Stadium stadium = GetById(c.Id);
            stadium.Name = c.Name;
            stadium.Price = c.Price;
            stadium.Area = c.Area;
            stadium.Note = c.Note;
            stadium.Image = c.Image;
            Save();
        }

        public void DeleteStadium(int id)
        {
            Stadium stadium = GetById(id);
            stadium.isDeleted = true;
            Save();
        }
    }
}
