using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using WPFTemplate.Configuration.Entity;

namespace WPFTemplate.Configuration.Repository
{
    public class ConfigContext : DbContext
    {
        public DbSet<MenuConfig> MenuConfigurationsRepository { get; set; }

        public DbSet<OptionGroup> OptionGroupsRepository { get; set; }

        public DbSet<OptionConfig> OptionConfigsRepository { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlite("Data Source=config.db");

        }

        public override int SaveChanges()
        {
            //添加操作
            ChangeTracker.Entries().Where(e => e is { State: EntityState.Added, Entity: BaseEntity }).ToList()
                .ForEach(e => ((BaseEntity)e.Entity).CreateTime = DateTime.Now);

            //修改操作
            ChangeTracker.Entries().Where(e => e is { State: EntityState.Modified, Entity: BaseEntity }).ToList()
                .ForEach(e => ((BaseEntity)e.Entity).UpdateTime = DateTime.Now);


            return base.SaveChanges();

        }
    }
}
