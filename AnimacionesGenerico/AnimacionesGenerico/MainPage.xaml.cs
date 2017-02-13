using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AnimacionesGenerico
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Stopwatch reloj;
        private int nHorasAnterior;
        private Random ram;

        public MainPage()
        {
            this.InitializeComponent();

            nHorasAnterior = 0;
            reloj = new Stopwatch();
            ram = new Random();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            reloj.Start();
        }

        private Ellipse CrearEllipse()
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Stroke = new SolidColorBrush(Colors.Black);
            myEllipse.Fill = new SolidColorBrush(Colors.Red);
            myEllipse.HorizontalAlignment = HorizontalAlignment.Left;
            myEllipse.VerticalAlignment = VerticalAlignment.Center;
            myEllipse.Width = 50;
            myEllipse.Height = 75;

            return myEllipse;
            
        }

        private void startAnimacion()
        {
          
            for (int n =0; n < ram.Next(1, 10); n++)
            {
                Ellipse elli = CrearEllipse();
                Canvas.SetLeft(elli, 40);
                Canvas.SetTop(elli, 400);
                CanvasDraw.Children.Add(elli);

                //TODO crear DoubleAnimation

                //TODO Añadir al ellipse la animacion
            }

            GloboStory.Begin();
        }

        private void timer_Tick(object sender, object e)
        {
            int nMinutos = reloj.Elapsed.Seconds;
            int nHoras = reloj.Elapsed.Minutes;
            

            MinutosAngulo.Angle = nMinutos * 360 / 60;
            HorasAngle.Angle = nHoras * 360 / 60;

            if (nHoras > nHorasAnterior)
            {
                nHorasAnterior = nHoras;
                startAnimacion();
            }
        }
    }
}
