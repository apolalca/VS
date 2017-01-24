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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace NuevoDomoticHome.View
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = true;
        }

        private void PaginaPrincipal_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Luz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Persianas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Alarma_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
