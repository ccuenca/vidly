using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<CustomerDto, Customer>();
                    cfg.CreateMap<Customer, CustomerDto>();
                });
        }
    }
}