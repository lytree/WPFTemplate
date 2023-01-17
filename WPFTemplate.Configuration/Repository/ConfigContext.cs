using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Configuration.Entity;

namespace WPFTemplate.Configuration.Repository
{
    public class ConfigContext : DbContext
    {
        public DbSet<MenuConfig> MenuConfigurationsRepository { get; set; }

        // public SQLiteDefaultContext(DbContextOptions<SQLiteDefaultContext> option) : base(option) { }
        public ConfigContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
            options.UseSqlite("Data Source=wpf.db");
        }

    }
}
