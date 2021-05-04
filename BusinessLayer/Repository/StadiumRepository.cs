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
            List<StadiumVM> list = GetAll(c => c.isDeleted == false).Select(c => new StadiumVM
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price,
                Area = c.Area,
                Note = c.Note,
                Image=c.Image
            }).ToList();
            return list;
        }

        public void AddStadium(StadiumVM c)
        {
            Add(new Stadium
            {
                Name = c.Name,
                Price = c.Price,
                Area = c.Area,
                Note = c.Note,
                isDeleted = false,
                Status = StadiumStatus.Free,
                Image=c.Image
            });
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
