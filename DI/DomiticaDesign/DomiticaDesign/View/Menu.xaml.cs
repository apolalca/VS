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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DomiticaDesign.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
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
            MenuButton1.Visibility = Visibility.Visible;
        }

        private void PaginaPrincipal_Click(object sender, RoutedEventArgs e)
        {
            Row1.Height = new GridLength(1 ,GridUnitType.Star);
            Row2.Height = new GridLength(0);
            Row3.Height = new GridLength(0);
            Row4.Height = new GridLength(0);
        }

        private void Luz_Click(object sender, RoutedEventArgs e)
        {
            Row1.Height = new GridLength(0);
            Row2.Height = new GridLength(1, GridUnitType.Star);
            Row3.Height = new GridLength(0);
            Row4.Height = new GridLength(0);
        }

        private void Persianas_Click(object sender, RoutedEventArgs e)
        {
            Row1.Height = new GridLength(0);
            Row2.Height = new GridLength(0);
            Row3.Height = new GridLength(1, GridUnitType.Star);
            Row4.Height = new GridLength(0);
        }

        private void Alarma_Click(object sender, RoutedEventArgs e)
        {
            Row1.Height = new GridLength(0);
            Row2.Height = new GridLength(0);
            Row3.Height = new GridLength(0);
            Row4.Height = new GridLength(1, GridUnitType.Star);
        }
    }
}
