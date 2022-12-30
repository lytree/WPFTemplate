using HandyControl.Tools;
using HandyControl.Tools.Extension;
using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using WPFTemplate.Data;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Layout;

/// <summary>
/// MainContent.xaml 的交互逻辑
/// </summary>
public partial class MainContent
{

    private bool _isFull;
    public MainContent()
    {
        InitializeComponent();
        WeakReferenceMessenger.Default.Register<MainContent, MessageToken.FullSwitch, string>(this, nameof(MessageToken.FullSwitch), (r, m) => this.FullSwitch(m.IsFull));
        DataContext = new MainContentViewsModel();
    }
    private void FullSwitch(bool isFull)
    {
        if (_isFull == isFull)
        {
            return;
        }

        _isFull = isFull;

        if (_isFull)
        {
            BorderRootEffect.Show();
            BorderEffect.Collapse();
            BorderTitle.Collapse();
            GridMain.HorizontalAlignment = HorizontalAlignment.Stretch;
            GridMain.VerticalAlignment = VerticalAlignment.Stretch;
            PresenterMain.Margin = new Thickness();
            BorderRoot.CornerRadius = new CornerRadius(10);
            BorderRoot.Style = ResourceHelper.GetResource<Style>("BorderClip");
        }
        else
        {
            BorderRootEffect.Collapse();
            BorderEffect.Show();
            BorderTitle.Show();
            GridMain.HorizontalAlignment = HorizontalAlignment.Center;
            GridMain.VerticalAlignment = VerticalAlignment.Center;
            PresenterMain.Margin = new Thickness(0, 0, 0, 10);
            BorderRoot.CornerRadius = new CornerRadius();
            BorderRoot.Style = null;
        }
    }
}