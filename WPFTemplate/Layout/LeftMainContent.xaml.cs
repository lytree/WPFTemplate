using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Data;
using HandyControl.Tools;

namespace WPFTemplate.Layout;

/// <summary>
/// LeftMainContent.xaml 的交互逻辑
/// </summary>
public partial class LeftMainContent
{
    public LeftMainContent()
    {
        InitializeComponent();
    }

    private void TabControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        throw new NotImplementedException();
    }
}

