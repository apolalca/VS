using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Personas.Model;
using UWP_Personas.View;
using UWP_Personas.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Personas
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

        /// <summary>
        /// Evento Click referente a la <see cref="Lista"/>, es la encargada de comprobar si estamos en un movil o el <see cref="MasterHide"/>
        /// esta en el modo movil, por tanto tenemos que enviar la persona seleccionada a la siguiente Vista <see cref="DetailPage"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lista_ItemClick(object sender, ItemClickEventArgs e)
        { 
            if (MasterHide.CurrentState == Movil)
            {
                Persona p = (Persona)e.ClickedItem;
                Frame.Navigate(typeof(DetailPage), p);
            }
        }

        /// <summary>
        /// Evento Click referente al <see cref="btnSave"/>, es el encargado de comprobar si estamos en el movil o
        /// el <see cref="MasterHide"/> en modo movil, por tanto cuando le pulsemos crearemos una persona nueva y la enviaremos
        /// la controlaremos en <see cref="DetailPage"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (MasterHide.CurrentState == Movil)
            {
                Persona p = new Persona();
                Frame.Navigate(typeof(DetailPage), p);
            }
        }
    }
}
