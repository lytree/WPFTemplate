using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Configuration.Entity;
using WPFTemplate.Configuration.Repository;
using WPFTemplate.Data.Model;

namespace WPFTemplate.Service;

public class DataService
{
    public List<MenuItemContent> GetMenuItemContents()
    {
        var list = new List<MenuItemContent>();
        using var config = new ConfigContext();
        foreach (var menu in config.MenuConfigurationsRepository.ToList())
        {
            
        }

        return list;
    }
}