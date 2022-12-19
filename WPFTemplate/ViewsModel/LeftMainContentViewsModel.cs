using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WPFTemplate.Data;
using WPFTemplate.Data.Model;
using WPFTemplate.Tools.Helper;

namespace WPFTemplate.ViewsModel;

public class LeftMainContentViewsModel : ViewModelBase<ViewsDataModel>
{
    public RelayCommand OpenHomeCmd => new(OpenHome);
    public RelayCommand<SelectionChangedEventArgs> SwitchDemoCmd => new(SwitchContent);

    
    private void SwitchContent(SelectionChangedEventArgs e)
    {
        if (e.AddedItems.Count == 0) return;
        if (e.AddedItems[0] is ContentItemModel item)
        {
            if (Equals(ContentItemCurrent, item)) return;
            SwitchContent(item);
        }
    }
    
    private void SwitchContent(ContentItemModel item)
    {
        ContentItemCurrent = item;
        ContentTitle = item.Name;
        var obj = AssemblyHelper.ResolveByKey(item.TargetCtlName);
        var ctl = obj ?? AssemblyHelper.CreateInternalInstance($"UserControl.{item.TargetCtlName}");
        Messenger.Send(new MessageToken.FullSwitch(true), nameof(MessageToken.FullSwitch));
        Messenger.Send(new MessageToken.LoadShowContent(obj), nameof(MessageToken.LoadShowContent));
    }
    private void OpenHome()
    {
        Messenger.Send(new MessageToken.ClearLeftSelected(null), nameof(MessageToken.ClearLeftSelected));
        Messenger.Send(new MessageToken.FullSwitch(true), nameof(MessageToken.FullSwitch));
        object obj = AssemblyHelper.CreateInternalInstance($"Views.{MessageToken.Home}");
        Messenger.Send(new MessageToken.LoadShowContent(obj), nameof(MessageToken.LoadShowContent));
    }
}