using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AnimacionesGenerico
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar
    /// dentro de un objeto Frame.
    /// REFERENCES:
    /// Crear Animacion
    //https://blogs.msdn.microsoft.com/silverlight_sdk/2008/03/24/create-an-animation-in-code-e-g-c-vb-net-etc/
    //Animacion eliminar cuando acabe
    //http://stackoverflow.com/questions/778795/removing-frameworkelements-on-animation-completion
    //Crear multilpes ellipses
    //https://social.msdn.microsoft.com/Forums/vstudio/en-US/2bdca0e5-c0f2-4748-b843-a654aafab65e/how-to-programmatically-create-multiple-ellipses-in-a-canvas-in-wpf?forum=wpf
    // Obtener el tamaño de la pantalla
    //https://code.msdn.microsoft.com/windowsapps/How-to-Get-Screen-563bc790
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Obtiene la hora en la que se esta, se utilizara este contador para recordar en que hora esta
        // y así obtener si ha cambiado o no para empezar la animacion.
        private int nHorasAnterior;
        private Stopwatch reloj;
        private Random ram;

        /// <summary>
        /// Inicia el reloj
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            //Modulo del reloj
            DispatcherTimer timer = new DispatcherTimer();
            reloj = new Stopwatch();
            ram = new Random();
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            reloj.Start();
            //Fin Relojs
            nHorasAnterior = 0;

        }

        #region Resolucion
        /// <summary> 
        /// Obtiene un relosucion de la pantalla.
        /// Ver REFERENCIAS
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private Size getResolution()
        {
            Size res;

            //Add the screen resolution information to the textblock. 
            if (App.ScreenResolutionSize != Size.Empty)
            {
                res = App.ScreenResolutionSize;
            }
            var windowSize = ScreenResolutionHelper.GetScreenResolutionInfo();
            //Add the application window's resolution information to the textblock. 
            if (windowSize != null)
            {
                res = windowSize;
            }
            return res;
        }

        /// <summary>
        /// Clase para obtener la resolucion llamando desde (APP) (App.xaml.cs)
        /// </summary>
        public class ScreenResolutionHelper
        {
            /// <summary> 
            /// Get screen resolution. 
            /// If you want to get the resolution on every page in your solution, you need to call this method from app.xaml.cs and save the data as a global variable. 
            /// If you have more than one computer monitor, you can only get the main monitor's screen resolution. 
            /// </summary> 
            /// <returns></returns> 
            public static Size GetScreenResolutionInfo()
            {
                var applicationView = ApplicationView.GetForCurrentView();
                var displayInformation = DisplayInformation.GetForCurrentView();
                var bounds = applicationView.VisibleBounds;
                var scale = displayInformation.RawPixelsPerViewPixel;
                var size = new Size(bounds.Width * scale, bounds.Height * scale);
                return size;
            }
        }

        #endregion

        #region Animacion


        /// <summary>
        /// Crea un Objeto Ellipse
        /// </summary>
        /// <returns>Objeto Ellipse</returns>
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


        /// <summary>
        /// Inicia la animacion, gracias a un random genera un numero de globos indeterminados
        /// y de una duracion aleatoria, cuando globo acabe este se borrará
        /// </summary>
        private void startAnimacion()
        {
            //Numero de Globos
            int max = ram.Next(10, 15);

            //Se debe PARAR EL STORYBOARD para añadir los objetos
            GloboStory.Stop();

            //SE aguardarán las resoluciones de la pantalla
            int resolutionWith = (int) getResolution().Width;
            int resolutionHeight = (int)getResolution().Height;

            for (int n =0; n < max; n++)
            {
                //Indica la posicion (With->Largo) que se posicionara el globo
                int posLeft = ram.Next(20, resolutionWith - 20);

                Ellipse elli = CrearEllipse();

                Canvas.SetLeft(elli, posLeft);
                Canvas.SetTop(elli, resolutionHeight);
                CanvasDraw.Children.Add(elli);

                //TODO crear DoubleAnimation
                DoubleAnimation doubleAnim = new DoubleAnimation();
                doubleAnim.Duration = new Duration(TimeSpan.FromSeconds(2));
                doubleAnim.BeginTime = TimeSpan.FromSeconds(ram.Next(1, 5));

                //Añade al Storyboard la animacion
                GloboStory.Children.Add(doubleAnim);

                Storyboard.SetTarget(doubleAnim, elli);
                Storyboard.SetTargetProperty(doubleAnim, "(Canvas.Top)");
                doubleAnim.To = 0;

                //Cuando se complete se eliminara
                doubleAnim.Completed += (s, e) => CanvasDraw.Children.Remove(elli);
            }

            GloboStory.Begin();
        }

      
        #endregion

        /// <summary>
        /// Pasa de minutos a angulos para configurar el reloj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, object e)
        {
            int nMinutos = reloj.Elapsed.Seconds;
            int nHoras = reloj.Elapsed.Minutes;
            

            MinutosAngulo.Angle = nMinutos * 360 / 60;
            HorasAngle.Angle = nHoras * 360 / 60;

            //Cuando nHoras haya cambiado significa que habra pasado una hora mas
            // al pasar una hora mas iniaremos la animacion
            if (nHoras > nHorasAnterior)
            {
                nHorasAnterior = nHoras;
                startAnimacion();
            }
        }
    }
}
