using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;

namespace WPFTemplate.ViewsModel
{
    public class ViewModelLocator
    {
        private readonly IContainer _icContainer;

        public ViewModelLocator()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            builder.RegisterType<MainContentViewsModel>().SingleInstance();
            _icContainer = builder.Build();
        }
        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
            Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;
        #region Vm
        public MainContentViewsModel Main => _icContainer.Resolve<MainContentViewsModel>();
        #endregion
    }
}
