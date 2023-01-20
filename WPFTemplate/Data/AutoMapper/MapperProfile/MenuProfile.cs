using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Configuration.Entity;
using WPFTemplate.Data.Model;

namespace WPFTemplate.Data.AutoMapper.MapperProfile
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<MenuConfig, MenuItemContent>()
                .ForMember(dest => dest.ImageName, option => option.MapFrom(src => src.IconName))
                .ReverseMap();
        }
    }
}
