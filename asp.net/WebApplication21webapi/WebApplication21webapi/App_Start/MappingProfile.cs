using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication21webapi.DTO;
using WebApplication21webapi.Models;

namespace WebApplication21webapi.App_Start
{
    public class MappingProfile : Profile
    { 
        public MappingProfile()
        {
            CreateMap<Emp, EmpDto>();
            CreateMap<EmpDto, Emp>();
        }
    }
}