using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Configuration.Entity;
using WPFTemplate.Configuration.Repository;
using WPFTemplate.Data.AutoMapper;
using WPFTemplate.Data.Model;

namespace WPFTemplate.Service;

public class DataService
{
    AutoMapperConfiguration _mapper;
    ConfigContext _configContext;

    public DataService(ConfigContext configContext, AutoMapperConfiguration autoMapperConfiguration)
    {
        _mapper = autoMapperConfiguration;
        _configContext = configContext;
    }
    public List<MenuItemContent> GetMenuItemContents()
    {
        return _mapper.Mapper.Map<List<MenuItemContent>>(_configContext.MenuConfigurationsRepository.ToList());
    }
}