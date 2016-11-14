using DataBlinding_13.Models;
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

namespace DataBlinding_13
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

        private void saveChanges(object sender, RoutedEventArgs e)
        {
            this.Nombre.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
            this.Apellido.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
            this.FechaNac.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
            this.Telefono.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
            this.Descripcion.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
        }

        }
}
