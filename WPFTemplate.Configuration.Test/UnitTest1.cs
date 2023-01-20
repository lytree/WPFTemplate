using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WPFTemplate.Configuration.Entity;
using WPFTemplate.Configuration.Repository;

namespace WPFTemplate.Configuration.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using ConfigContext sQLite = new();
            sQLite.Database.Migrate();
            sQLite.MenuConfigurationsRepository.Add(new MenuConfig()
            {
                IconName = "web",
                TargetCtlName = "web",
                Name = "Name",
                QueriesText = "web«∂»Î",
                IsVisible = true,
            });
            sQLite.SaveChanges();

           
           
        }
    }
}