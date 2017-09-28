using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication22wedassgnmnt.DTO;
using WebApplication22wedassgnmnt.Models;
using AutoMapper;

namespace WebApplication22wedassgnmnt.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentVM, StudentDto>();
            CreateMap<StudentDto, StudentVM>();
        }
    }
}