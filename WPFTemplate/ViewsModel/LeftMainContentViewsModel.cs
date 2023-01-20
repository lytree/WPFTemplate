using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Threading;
using Autofac;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Properties.Langs;
using WPFTemplate.Data;
using WPFTemplate.Data.Model;
using WPFTemplate.Service;
using WPFTemplate.Tools.Helper;
using static WPFTemplate.Data.MessageToken;

namespace WPFTemplate.ViewsModel;

public class LeftMainContentViewsModel : ObservableRecipient
{
    public MenuItemContent MenuItemContentCurrent { get; set; }
    public List<MenuItemContent> ContextItemList { get; set; }
    public RelayCommand OpenHomeCmd => new(OpenHome);

    public RelayCommand<SelectionChangedEventArgs> SwitchContentCommandCmd => new(SwitchContentCommand);

    public LeftMainContentViewsModel()
    {
        var dataService = ViewModelLocator.Instance.Container.Resolve<DataService>();
        this.ContextItemList = dataService.GetMenuItemContents();

        UpdateLeftContent();
    }
    private void OpenHome()
    {
        Messenger.Send(new MessageToken.ClearLeftSelected(null), nameof(MessageToken.ClearLeftSelected));
        Messenger.Send(new MessageToken.FullSwitch(true), nameof(MessageToken.FullSwitch));
        object obj = AssemblyHelper.CreateInternalInstance($"Views.{MessageToken.Home}");
        Messenger.Send(new MessageToken.LoadShowContent(obj), nameof(MessageToken.LoadShowContent));
    }
    private void UpdateLeftContent()
    {
        // //clear status
        // Messenger.Register<LeftMainContentViewsModel, ClearLeftSelected, string>(this, nameof(ClearLeftSelected), (r, obj) =>
        // {
        //     MenuItemContentCurrent = null;
        //     foreach (var item in ContextItemList)
        //     {
        //         item.SelectedIndex = -1;
        //     }
        // });

        ////load items
        //DemoInfoCollection = new ObservableCollection<ContextInfoModel>();
        //Task.Run(() =>
        //{
        //    DataList = _dataService.GetDemoDataList();

        //    foreach (var item in _dataService.GetDemoInfo())
        //    {
        //        Application.Current.Dispatcher.BeginInvoke(new Action(() =>
        //        {
        //            DemoInfoCollection.Add(item);
        //        }), DispatcherPriority.ApplicationIdle);
        //    }
        //});
    }
    private void SwitchContentCommand(SelectionChangedEventArgs e)
    {
        if (e.AddedItems.Count == 0) return;
        if (e.AddedItems[0] is MenuItemContent item)
        {
            if (Equals(MenuItemContentCurrent, item)) return;
            SwitchContentCommand(item);
        }
    }

    private void SwitchContentCommand(MenuItemContent item)
    {
        MenuItemContentCurrent = item;
        ViewModelLocator.Instance.Main.ContentTitle = item.Name;
        var obj = AssemblyHelper.ResolveByKey(item.TargetCtlName);
        var ctl = obj ?? AssemblyHelper.CreateInternalInstance($"Views.{item.TargetCtlName}");
        Messenger.Send(new MessageToken.LoadShowContent(ctl), nameof(MessageToken.LoadShowContent));
    }
}