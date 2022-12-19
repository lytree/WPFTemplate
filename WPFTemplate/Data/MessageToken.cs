using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandyControl.Themes;

namespace WPFTemplate.Data
{

    class MessageToken
    {
        public static readonly string Home = nameof(Home);
        public sealed class ClearLeftSelected
        {
            public ClearLeftSelected(object obj)
            {
                Obj = obj;
            }

            public object Obj { get; set; }
        }

        public sealed class LoadShowContent
        {
            public LoadShowContent(object obj)
            {
                this.Obj = obj;
            }

            public object Obj { get; set; }
        }


        public sealed class SkinUpdated
        {
            public SkinUpdated(ApplicationTheme theme)
            {
                Theme = theme;
            }

            public ApplicationTheme Theme { get; set; }
        }

        public sealed class FullSwitch
        {
            public FullSwitch(bool isFull)
            {
                IsFull = isFull;
            }

            public bool IsFull { get; set; }
        }

    }
}
