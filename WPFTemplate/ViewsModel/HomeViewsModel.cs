using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Data;

namespace WPFTemplate.ViewsModel
{

    public class HomeViewsModel : ObservableRecipient
    {
        private double _contentHeight;
        private double _contentWidth;

        public HomeViewsModel()
        {
            UpdateMainContentSize();
        }

        private void UpdateMainContentSize()
        {

            Messenger.Register<HomeViewsModel, MessageToken.WindowsSize, string>(this,
                nameof(HomeViewsModel),
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
