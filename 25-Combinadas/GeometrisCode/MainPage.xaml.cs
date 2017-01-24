using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GeometrisCode
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool stop = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stop == true)
                stop = false;
            else
                stop = true;

            while (stop)
            {
                var ellipse1 = new Ellipse();
                ellipse1.Fill = new SolidColorBrush(Windows.UI.Colors.SteelBlue);
                ellipse1.Width = 200;
                ellipse1.Height = 200;
                ellipse1.Name = "ellip";

                Canvas.SetLeft(ellipse1, 800);
                layoutRoot.Children.Add(ellipse1);
                story.Begin();
            }
        }
    }
}
