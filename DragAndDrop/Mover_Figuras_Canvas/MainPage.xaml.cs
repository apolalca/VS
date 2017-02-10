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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mover_Figuras_Canvas
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        void Img_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {

            image.Opacity = 0.5;
        }

        void Img_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            mytransform.TranslateX += e.Delta.Translation.X;
            mytransform.TranslateY += e.Delta.Translation.Y;
        }

        void Img_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {

            image.Opacity = 1;
        }
    }
}
