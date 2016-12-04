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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Repoductor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            this.Nombre_Artista.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.Nombre_Cancion.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.Genero.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            this.Descripcion.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }

        /// <summary>
        /// Cuando se pulse con el boton derecho se llamará a este metodo encargado de mostrar el menu flyout.
        /// <seealso cref="RightTappedRoutedEventArgs"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            ListView list = (ListView)sender;
            allContactMenu.ShowAt(list, e.GetPosition(list));
            var a = ((FrameworkElement)e.OriginalSource).DataContext;
        }
    }
}
