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
using WPFTemplate.Data;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Views
{
    /// <summary>
    /// Web.xaml 的交互逻辑
    /// </summary>
    public partial class Web 
    {
        public Web()
        {
            InitializeComponent();
            DataContext = new WebViewsModel();
            SizeChanged += Web_SizeChanged;
        }

        private void Web_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WeakReferenceMessenger.Default.Send(new MessageToken.WindowsSize(ActualWidth,ActualHeight,true), nameof(WebViewsModel));

        }
    }
}
