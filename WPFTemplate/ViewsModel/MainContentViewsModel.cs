using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WPFTemplate.Data;
using WPFTemplate.Layout;

namespace WPFTemplate.ViewsModel
{
    public class MainContentViewsModel : ObservableRecipient
    {
        public MainContentViewsModel()
        {

        }

        private void UpdateMainContent()
        {
            Messenger.Register<object>(this, MessageToken.LoadShowContent, obj =>
            {
                if (SubContent is IDisposable disposable)
                {
                    disposable.Dispose();
                }
                SubContent = obj;
            }, true);
        }

    }
}
