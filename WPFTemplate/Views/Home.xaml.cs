using CommunityToolkit.Mvvm.Messaging;
using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using WPFTemplate.Data;
using WPFTemplate.ViewsModel;

namespace WPFTemplate.Views
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home
    {
        Crosshair Crosshair;
        public Home()
        {
            InitializeComponent();
            DataContext = new HomeViewsModel();
            SizeChanged += Home_SizeChanged;
            wpfPlot1.Plot.AddSignal(DataGen.Sin(50000));
            wpfPlot1.Plot.AddSignal(DataGen.Cos(50000));
            wpfPlot1.Plot.AxisAuto();
            wpfPlot1.Plot.SetOuterViewLimits(0, 50000, -1, 1);
            Crosshair = wpfPlot1.Plot.AddCrosshair(0, 0);
            wpfPlot1.Refresh();
        }

        private void Home_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WeakReferenceMessenger.Default.Send(new MessageToken.WindowsSize(ActualWidth,ActualHeight,true), nameof(HomeViewsModel));

        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            int pixelX = (int)e.MouseDevice.GetPosition(wpfPlot1).X;
            int pixelY = (int)e.MouseDevice.GetPosition(wpfPlot1).Y;

            (double coordinateX, double coordinateY) = wpfPlot1.GetMouseCoordinates();
            //
            // XPixelLabel.Content = $"{pixelX:0.000}";
            // YPixelLabel.Content = $"{pixelY:0.000}";
            //
            // XCoordinateLabel.Content = $"{wpfPlot1.Plot.GetCoordinateX(pixelX):0.00000000}";
            // YCoordinateLabel.Content = $"{wpfPlot1.Plot.GetCoordinateY(pixelY):0.00000000}";

            Crosshair.X = coordinateX;
            Crosshair.Y = coordinateY;
            wpfPlot1.Refresh();
        }

        private void wpfPlot1_MouseEnter(object sender, MouseEventArgs e)
        {
            Crosshair.IsVisible = true;
           
        }

        private void wpfPlot1_MouseLeave(object sender, MouseEventArgs e)
        {
            Crosshair.IsVisible = false;
            wpfPlot1.Refresh();

        }
    }
}
