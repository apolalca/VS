using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ExamenCartas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Stopwatch reloj;

        public MainPage()
        {
            this.InitializeComponent();
            reloj = new Stopwatch();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            reloj.Start();
        }

        private void timer_Tick(object sender, object e)
        {
            Reloj.Text = string.Format("{0}:{1}:{2}", reloj.Elapsed.Hours.ToString(),
                reloj.Elapsed.Minutes.ToString(),
                reloj.Elapsed.Seconds.ToString());
        }

        public void Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            reloj.Restart();
        }


    }
}
