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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Coord c = new Coord();
            var position = await LocationManager.GetPosition();

            c.lat = position.Coordinate.Latitude;
            c.lon = position.Coordinate.Longitude;

            RootObject whater = await Connection.getWheater(c);
            String icon = String.Format("ms-appx:///Assets/img/{0}.png", whater.weather[0].icon);
            ResultImg.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));



            ResultWhater.Text = whater.name + " - " + ((int)whater.main.temp).ToString()  + " - " + whater.weather[0].description;

        }
    }
}
