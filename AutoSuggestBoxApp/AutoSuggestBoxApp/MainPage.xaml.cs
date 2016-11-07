
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls;


// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AutoSuggestBoxApp
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string[] names;

        public MainPage()
        {
            this.InitializeComponent();

            getNames();
        }

        /// <summary>
        /// Recoge los nombres del xml en la carpeta raiz
        /// </summary>
        private void getNames()
        {
            names = XDocument.Load(@"./Nombres.xml").Descendants("name").Select(x => x.Value).ToArray();
        }

        /// <summary>
        /// Cada vez  que el SuggestBox cambie se llamara a este metodo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            string text;

            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                text = sender.Text;
                if (sender.Text.Length >= 1 )
                {
                    sender.ItemsSource = getSuggestion(text);
                }
                else
                {
                    sender.ItemsSource = new string[] { "No suggestion" };
                }   
            }
        }

        /// <summary>
        /// Buscará en el string array la palabra introducida por parametros con los nombres del array name.
        /// El resultado se filtrara por orden de inicio no por contenido.
        /// </summary>
        /// <param name="text">Palabra introducida</param>
        /// <returns>Array con os resultados</returns>
        private object getSuggestion(string text)
        {
            string[] result = null;
            result = names.Where(x => x.StartsWith(text)).ToArray();
            return result;
        }

    }
}
