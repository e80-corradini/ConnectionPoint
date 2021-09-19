using AutoMapper;
using ConnectionPoint.Domain.Models;
using ConnectionPoint.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionPoint.Shared
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Device, DeviceDTO>().ReverseMap();
            CreateMap<Handover, HandoverDTO>().ReverseMap();
            CreateMap<Vpn, VpnDTO>().ReverseMap();
            CreateMap<VpnType, VpnTypeDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<DeviceType, DeviceTypeDTO>().ReverseMap();

        }
    }
}
