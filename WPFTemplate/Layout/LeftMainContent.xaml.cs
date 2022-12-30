using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Data;
using HandyControl.Tools;
using WPFTemplate.Data;
using WPFTemplate.Tools.Helper;
using WPFTemplate.Views;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Layout;

/// <summary>
/// LeftMainContent.xaml 的交互逻辑
/// </summary>
public partial class LeftMainContent
{
    public LeftMainContent()
    {
        InitializeComponent();
        DataContext = new LeftMainContentViewsModel();
    }
    
   
}

