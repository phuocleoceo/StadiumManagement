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

            CreateMap<AccountInformation, AccountInformationVM>()
                .ForMember(aivm => aivm.Account_Name, prop => prop.MapFrom(ai => ai.Account.UserName));
            CreateMap<AccountInformationVM, AccountInformation>();

            CreateMap<ServiceOrder, ServiceOrderVM>()
                .ForMember(svm => svm.Bill_Code, prop => prop.MapFrom(s => s.Bill.BillCode))
                .ForMember(svm => svm.Service_Name, prop => prop.MapFrom(s => s.Service.Name))
                .ForMember(svm => svm.Service_Image, prop => prop.MapFrom(s => s.Service.Image));
            CreateMap<ServiceOrderVM, ServiceOrder>();

            CreateMap<RentOrder, RentOrderVM>()
                .ForMember(rvm => rvm.Bill_Code, prop => prop.MapFrom(r => r.Bill.BillCode))
                .ForMember(rvm => rvm.Stadium_Name, prop => prop.MapFrom(r => r.Stadium.Name))
                .ForMember(rvm => rvm.Stadium_Image, prop => prop.MapFrom(r => r.Stadium.Image));
            CreateMap<RentOrderVM, RentOrder>();

            CreateMap<Bill, BillVM>()
                .ForMember(bvm => bvm.Customer_Name, prop => prop.MapFrom(b => b.Customer.Name))
                .ForMember(bvm => bvm.Customer_Phone, prop => prop.MapFrom(b => b.Customer.PhoneNumber))
                .ForMember(bvm => bvm.Cashier_Name, prop => prop.MapFrom(b => b.Cashier.Name));
            CreateMap<BillVM, Bill>();
        }
    }
}
