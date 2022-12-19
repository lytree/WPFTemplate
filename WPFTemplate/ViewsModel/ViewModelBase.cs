using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPFTemplate.ViewsModel;

public class ViewModelBase<T> : ObservableRecipient
{
    /// <summary>
    ///     数据列表
    /// </summary>
    private IList<T>? _dataList;

    /// <summary>
    ///     数据列表
    /// </summary>
    public IList<T>? DataList
    {
        get => _dataList;

        set => SetProperty(ref _dataList, value);

    }
}