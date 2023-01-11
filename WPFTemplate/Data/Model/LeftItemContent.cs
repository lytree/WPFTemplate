using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Data.Model
{
    public class LeftItemContent : ObservableObject
    {
        private bool _isVisible = true;
        private string _queriesText = string.Empty;
        public string ImageName { get; set; }
        public string Name { get; set; }

        public string TargetCtlName { get; set; }
        public bool IsNew { get; set; }
        public string QueriesText { get => _queriesText; set => SetProperty(ref _queriesText, value); }
        public bool IsVisible { get => _isVisible; set => SetProperty(ref _isVisible, value); }

        public LeftItemContent(string imageName, string name, string queriesText,string targetCtlName, bool isNew)
        {
            ImageName = $"../../Resources/Img/LeftMainContent/{imageName}.png";
            Name = name;
            QueriesText = queriesText;
            IsNew = isNew;
            TargetCtlName = targetCtlName;
        }
    }
}
