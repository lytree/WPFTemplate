using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPFTemplate.Data;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Views
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home
    {
        public Home()
        {
            InitializeComponent();
            DataContext = new HomeViewsModel();
            SizeChanged += Home_SizeChanged;
        }

        private void Home_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WeakReferenceMessenger.Default.Send(new MessageToken.WindowsSize(ActualWidth,ActualHeight,true), nameof(HomeViewsModel));

        }
    }
}
