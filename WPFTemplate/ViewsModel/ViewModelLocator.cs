using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Microsoft.EntityFrameworkCore;
using WPFTemplate.Configuration.Repository;
using WPFTemplate.Data.AutoMapper;
using WPFTemplate.Service;

namespace WPFTemplate.ViewsModel
{
    public class ViewModelLocator
    {
        public readonly IContainer Container;

        public ViewModelLocator()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            builder.RegisterType<MainContentViewsModel>().SingleInstance();
            builder.RegisterType<AutoMapperConfiguration>().SingleInstance();
            builder.RegisterType<ConfigContext>().SingleInstance();
            builder.RegisterType<DataService>().SingleInstance();
            Container = builder.Build();
            Container.Resolve<ConfigContext>().Database.Migrate();
        }
        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
            Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;
        #region Vm
        public MainContentViewsModel Main => Container.Resolve<MainContentViewsModel>();

        #endregion
    }
}
