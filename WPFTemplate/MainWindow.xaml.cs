﻿using CommunityToolkit.Mvvm.Messaging;
using HandyControl.Controls;
using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTemplate.Data;
using WPFTemplate.Tools.Helper;

namespace WPFTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnContentRendered(EventArgs e)
        {

            NonClientAreaContent = new NonClientAreaContent();
            ControlMain.Content = new MainWindowContent();
            base.OnContentRendered(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (GlobalData.NotifyIconIsShow)
            {
                Hide();
                e.Cancel = true;
            }
            else
            {
                base.OnClosing(e);
            }
        }
    }
}