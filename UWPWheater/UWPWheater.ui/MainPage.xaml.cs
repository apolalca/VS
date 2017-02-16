using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPWheater.dal;
using UWPWheater.ent.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPWheater.ui
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn_VerTiempo.Visibility = Visibility.Collapsed;
            pb_Carga.IsIndeterminate = true;
            getWheater();
            pb_Carga.IsIndeterminate = false;
        }

        private async void getWheater()
        {
            Coord c = new Coord();
            var position = await LocationManager.GetPosition();

            c.lat = position.Coordinate.Point.Position.Latitude;
            c.lon = position.Coordinate.Point.Position.Longitude;

            RootObject whater = await Connection.getWheater(c);
            try
            {
                String icon = String.Format("ms-appx:///Assets/img/{0}.png", whater.weather[0].icon);
                ResultImg.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
                ResultWhater.Text = whater.name + " - " + ((int)whater.main.temp).ToString() + " - " + whater.weather[0].description;
            }
            catch (Exception)
            {
                //Debido a que son dos hilos y no hemos dado hilos en c# suele ocurrir la primera vez que se ejecuta la aplicacion un error
                //de nulo, ya que el primer hilo (El que pide la autorizacion para coger la localizacion) mientras espera la respuesta
                //del usuario y no ya le ha dado tiempo al segundo de enviar el GET con la lat y la lon sin rellenar ergo sale nulo.
                ResultWhater.Text = "Ha ocurrido un problema inesperado, por favor vuelva a intentarlo";
                btn_VerTiempo.Visibility = Visibility.Visible;
            }
        }
    }
}
