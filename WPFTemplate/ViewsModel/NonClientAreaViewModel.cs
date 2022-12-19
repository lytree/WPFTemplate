using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using WPFTemplate.Data;
using WPFTemplate.Tools.Helper;

namespace WPFTemplate.ViewsModel;

public class NonClientAreaViewModel : ObservableRecipient
{
    
    public RelayCommand<string> OpenViewCmd => new(execute: OpenView);

    private void OpenView(string? viewName)
    {
        Console.WriteLine(viewName);
        Messenger.Send(new MessageToken.ClearLeftSelected(null), nameof(MessageToken.ClearLeftSelected));
        Messenger.Send(new MessageToken.FullSwitch(true), nameof(MessageToken.FullSwitch));
        object obj =  AssemblyHelper.CreateInternalInstance($"Views.{viewName}");
        Messenger.Send(new MessageToken.LoadShowContent(obj), nameof(MessageToken.LoadShowContent));
    }
}