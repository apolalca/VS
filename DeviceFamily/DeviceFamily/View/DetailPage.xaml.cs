using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using DeviceFamily.Model;
using DeviceFamily.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DeviceFamily.View
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
        [System.Obsolete("use SystemNavigationManager")]
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

            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested += DetailPage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
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

        private void DetailPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            // Mark event as handled so we don't get bounced out of the app.
            e.Handled = true;

            OnBackRequested();
        }

        private void OnBackRequested()
        {
            // Page above us will be our master view.
            // Make sure we are using the "drill out" animation in this transition.

            Frame.GoBack(new DrillInNavigationTransitionInfo());
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested -= DetailPage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

    }
}
