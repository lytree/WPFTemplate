using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WPFTemplate.Data;
using WPFTemplate.Layout;
using static WPFTemplate.Data.MessageToken;

namespace WPFTemplate.ViewsModel
{
    public class MainContentViewsModel : ObservableRecipient
    {
        private object _contentTitle;
        private object _subContent;
        public object SubContent
        {
            get => _subContent;

            set => SetProperty(ref _subContent, value);

        }

        public object ContentTitle
        {
            get => _contentTitle;

            set => SetProperty(ref _contentTitle, value);

        }
        public MainContentViewsModel()
        {
            UpdateMainContent();
        }
        private void UpdateMainContent()
        {
            Messenger.Register<MainContentViewsModel, LoadShowContent, string>(this, nameof(LoadShowContent), (r, obj) =>
            {
                if (SubContent is IDisposable disposable)
                {
                    disposable.Dispose();
                }
                SubContent = obj.Obj;
            });
        }


    }
}
