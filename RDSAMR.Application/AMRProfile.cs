using AutoMapper;
using RDSAMR.Application.ViewModels;
using RDSAMR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDSAMR.Application
{
    public class AMRProfile:Profile
    {
        public AMRProfile()
        {
            CreateMap<CountryVM, Country>().ReverseMap();
            
            CreateMap<StateVM, State>().ReverseMap();
            
            CreateMap<CityVM, City>().ReverseMap();

            CreateMap<UserVM, User>().ReverseMap();

            CreateMap<RoleVM, Role>().ReverseMap();
        }
    }
}
