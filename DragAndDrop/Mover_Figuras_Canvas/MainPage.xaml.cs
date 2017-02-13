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

namespace Mover_Figuras_Canvas
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double x;
        private double y;
        private static int REDONDEAR = 1;

        public MainPage()
        {
            this.InitializeComponent();
            x = Math.Round(BunaPos.RadiusX, REDONDEAR);
            y = Math.Round(BunaPos.RadiusY, REDONDEAR);
        }

        void Img_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            image.Opacity = 0.5;
        }

        void Img_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            double x = Math.Round(e.Delta.Translation.X, REDONDEAR);
            double y = Math.Round(e.Delta.Translation.Y, REDONDEAR);

            mytransform.TranslateX += 1;
            mytransform.TranslateY += 1;

            if (isCheck(x, y))
            {
                crearDialogo();
            }
        }

        private async void crearDialogo()
        {
            var dialog = new Windows.UI.Popups.MessageDialog("Bien hecho!");

            await dialog.ShowAsync();
        }

        private bool isCheck(double x, double y)
        {
            bool good = false;

            if (x == this.x && y == this.y)
                good = true;

            return good;
        }

        void Img_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            image.Opacity = 1;
        }
    }
}
