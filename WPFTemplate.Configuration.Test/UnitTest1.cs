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
            sQLite.Database.EnsureCreated();
            sQLite.MenuConfigurationsRepository.Add(new MenuConfig() { TargetCtlName = "test", ImageName = "Name",IsVisible = false });
            sQLite.SaveChanges();
        }
    }
}