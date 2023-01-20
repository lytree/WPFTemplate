using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Data.AutoMapper.MapperProfile;
using WPFTemplate.Data.Model;

namespace WPFTemplate.Data.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public readonly IMapper Mapper;

        public AutoMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MenuProfile>();
            });
            Mapper = config.CreateMapper();
        }

    }
}
