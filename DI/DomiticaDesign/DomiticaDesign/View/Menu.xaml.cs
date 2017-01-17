﻿using System;
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
            PrincipalFrame.Navigate(typeof(View.CasaMapa));
            PrincipalFrame.Visibility = Visibility.Visible;
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
