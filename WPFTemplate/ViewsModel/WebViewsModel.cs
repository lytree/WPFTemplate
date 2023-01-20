using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Data;

namespace WPFTemplate.ViewsModel
{
    public class WebViewsModel : ObservableRecipient
    {
        
        private double _contentHeight;
        private double _contentWidth;

        public WebViewsModel()
        {
            UpdateMainContentSize();
        }

        private void UpdateMainContentSize()
        {

            Messenger.Register<WebViewsModel, MessageToken.WindowsSize, string>(this,
                nameof(WebViewsModel),
                (r, m) =>
                {
                    {
                        if (m.IsChange)
                        {
                            ContentHeight = m.WindowsHeight - (36 * 2);
                            ContentWidth = m.WindowsWidth - (36 * 2);

                        }
                    }
                });
        }
        public double ContentHeight
        {
            get => _contentHeight;
            set => SetProperty(ref _contentHeight, value);
        }

        public double ContentWidth
        {
            get => _contentWidth;
            set => SetProperty(ref _contentWidth, value);
        }
    }
}
