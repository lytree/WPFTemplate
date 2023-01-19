using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Controls;
using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFTemplate.Layout;
using WPFTemplate.Tools.Helper;

namespace WPFTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            //顶部菜单栏
            NonClientAreaContent = new NonClientAreaContent();
            //主题部分
            ControlMain.Content = new MainWindowContent();
            WeakReferenceMessenger.Default.Send(new MessageToken.FullSwitch(true), nameof(MessageToken.FullSwitch));
            WeakReferenceMessenger.Default.Send(new MessageToken.LoadShowContent(AssemblyHelper.CreateInternalInstance($"Views.{MessageToken.Home}")), nameof(MessageToken.LoadShowContent));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (GlobalData.NotifyIconIsShow)
            {
                Hide();
                e.Cancel = true;
            }
            else
            {
                base.OnClosing(e);
            }
        }
    }
}
