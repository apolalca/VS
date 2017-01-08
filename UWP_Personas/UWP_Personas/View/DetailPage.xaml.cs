using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Personas.Model;
using UWP_Personas.ViewModel;
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

namespace UWP_Personas.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailPage : Page
    {
        public DetailPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Encargado de volver atras a <see cref="MainPage"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        /// <summary>
        /// Encargado de recibir los datos, este metodo será llamado cada vez que se inicie todos los <see cref="MainPage"/>
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Persona p = e.Parameter as Persona;
            
            if (p != null)
            {
                ViewModelPersonas.PersonaSeleccionada = p;
            }
            else
            {
                MostrarErorr();
            }
        }

        /// <summary>
        /// Encargado de mostrar un dialogo con el error, que la persona esta vacia.
        /// Nunca una persona puede venir nula
        /// </summary>
        private async void MostrarErorr()
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Error";
            dialog.Content = "Ha ocurrido un error la persona esta vacia!";
            await dialog.ShowAsync();
        }

        /*private void AppBarButton_PointerCanceled(object sender, PointerRoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        } */
    }
}
