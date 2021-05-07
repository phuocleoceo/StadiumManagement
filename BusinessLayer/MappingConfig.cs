using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Models;
using BusinessLayer.ViewModels;
using DataAccessLayer.Enums;

namespace BusinessLayer
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Stadium, StadiumVM>().ReverseMap();
            CreateMap<Service, ServiceVM>().ReverseMap();
        }
    }
}
