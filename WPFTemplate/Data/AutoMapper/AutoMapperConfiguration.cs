using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Data.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static IMapper Mapper;

        public AutoMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg => { });
           Mapper = config.CreateMapper();
        }

    }
}
