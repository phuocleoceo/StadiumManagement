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
            CreateMap<Customer, CustomerVM>().ReverseMap();

            CreateMap<Account, AccountVM>()
                .ForMember(avm => avm.Role, prop => prop.MapFrom(a => Enum.GetName(typeof(Role), a.Role)));
            CreateMap<AccountVM, Account>()
                .ForMember(a => a.Role, prop => prop.MapFrom(avm => (Role)Enum.Parse(typeof(Role), avm.Role)))
                .ForMember(a => a.PassWord, prop => prop.MapFrom(avm => avm.PassWord.GetMD5()));
        }
    }
}
