using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Extension;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPFTemplate.Tools.Helper;

namespace WPFTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    public partial class App : Application
    {
        private static Mutex? AppMutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            AppMutex = new Mutex(true, "WPFTemplate", out var createdNew);

            if (!createdNew)
            {
                var current = Process.GetCurrentProcess();

                foreach (var process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id != current.Id)
                    {
                        Win32Helper.SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
                Shutdown();
            }
            else
            {
                var splashScreen = new SplashScreen("/Resources/Img/Cover.png");
                splashScreen.Show(true);

                base.OnStartup(e);

                ApplicationHelper.IsSingleInstance();

                ShutdownMode = ShutdownMode.OnMainWindowClose;
                ConfigHelper.Instance.SetWindowDefaultStyle();
                ConfigHelper.Instance.SetNavigationWindowDefaultStyle();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
               
            }

        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        internal void UpdateSkin(ApplicationTheme theme)
        {
            ThemeManager.Current.ApplicationTheme = theme;

            var demoResources = new ResourceDictionary
            {
                Source = ApplicationHelper.GetAbsoluteUri("WPFTemplate",
                    $"/Resources/Themes/Basic/Colors/{theme}.xaml")
            };

            Resources.MergedDictionaries[0].MergedDictionaries.InsertOrReplace(1, demoResources);
        }
    }

}
