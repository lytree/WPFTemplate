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
using System.Windows.Shapes;

namespace WPFTemplate.UserControl
{
    /// <summary>
    /// AboutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AboutWindow
    {
        public AboutWindow()
        {
            InitializeComponent();
            CopyRight = "WPFTemplate";
            Version = "1.0";
        }
        public string CopyRight
        {
            get ;
            set ;
        }

        public static readonly DependencyProperty VersionProperty = DependencyProperty.Register(
            nameof(Version), typeof(string), typeof(AboutWindow), new PropertyMetadata(default(string)));

        public string Version
        {
            get ;
            set ;
        }
    }
}
