using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Themes;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Data
{

    public class MessageToken
    {
        public static readonly string Home = nameof(Home);
        public static readonly string GlobalSeeting = nameof(GlobalSeeting);

        public sealed class ClearLeftSelected
        {
            public ClearLeftSelected(object obj)
            {
                Obj = obj;
            }

            public object Obj { get; set; }
        }
        //功能区域变更
        public sealed class LoadShowContent
        {
            public LoadShowContent(object obj)
            {
                this.Obj = obj;
            }

            public object Obj { get; set; }
        }
        //皮肤变更

        public sealed class SkinUpdated
        {
            public SkinUpdated(ApplicationTheme theme)
            {
                Theme = theme;
            }

            public ApplicationTheme Theme { get; set; }
        }
        //全屏切换
        public sealed class FullSwitch
        {
            public FullSwitch(bool isFull)
            {
                IsFull = isFull;
            }

            public bool IsFull { get; set; }
        }

        public sealed class WindowsSize
        {
            public WindowsSize(double width, double height,bool isChange)
            {
                WindowsHeight=height;
                WindowsWidth=width;
                IsChange=isChange;
            }


            public double WindowsHeight { get; set; }
            public double WindowsWidth { get; set; }
            public bool IsChange { get; set; }
        }
    }
}
