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
using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Controls;
using HandyControl.Themes;
using WPFTemplate.Data;
using WPFTemplate.UserControl;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Layout;

/// <summary>
/// NonClientAreaContent.xaml 的交互逻辑
/// </summary>
public partial class NonClientAreaContent
{
    public NonClientAreaContent()
    {
        InitializeComponent();
        DataContext = new NonClientAreaViewModel();
    }

    //private void ButtonSkins_OnClick(object sender, RoutedEventArgs e)
    //{
    //    if (e.OriginalSource is Button button && button.Tag is ApplicationTheme tag)
    //    {
    //        PopupConfig.IsOpen = false;
    //        if (tag.Equals(GlobalData.Config.Theme)) return;
    //        GlobalData.Config.Theme = tag;
    //        GlobalData.Save();
    //        ((App)Application.Current).UpdateSkin(tag);
    //        WeakReferenceMessenger.Default.Send(new MessageToken.SkinUpdated(tag), nameof(MessageToken.SkinUpdated));
    //    }
    //}

    private void MenuAbout_OnClick(object sender, RoutedEventArgs e)
    {
        new AboutWindow
        {
            Owner = Application.Current.MainWindow
        }.ShowDialog();
    }
}

