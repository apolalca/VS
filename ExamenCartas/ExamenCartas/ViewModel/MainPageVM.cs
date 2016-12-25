using ExamenCartas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ExamenCartas.ViewModel
{
    public class MainPageVM : VMBase
    {
        private ObservableCollection<Carta> _lista;
        // Carta dos seleccioanda
        private Carta _cartaUno;
        // Carta 1 seleccionada
        private Carta _cartaDos;
        /* *
         * Los inten seleccionados de la lista será introducito a traves de aqui.
         * */
        private Carta _Seleccionada;
        //Boton restart
        private DelegateCommand _restart;
        //Contador aciertos
        private int nAciertos;
        //Especifica a que numero se ha llegado al maximo de aciertos y el juego deberia terminar.
        private int nAciertoMaximo;

        #region Constructores

        public MainPageVM()
        {
            _lista = new ObservableCollection<Carta>();
            _lista = Listado.startList();

            _cartaUno = null;
            _cartaDos = null;

            nAciertos = 0;
            nAciertoMaximo = _lista.Count / 2;

            _restart = new DelegateCommand(restartd_Execute, restart_CanExecute);
        }

        #endregion

        #region Propiedades

        public ObservableCollection<Carta> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                _lista = value;
                NotifyPropertyChanged("Lista");
            }
        }

        public Carta CartaUno
        {
            get
            {
                return _cartaUno;
            }
            set
            {
                _cartaUno = value;
                NotifyPropertyChanged("CartaUno");
            }
        }

        public Carta CartaDos
        {
            get
            {
                return _cartaDos;
            }
            set
            {
                _cartaDos = value;
                NotifyPropertyChanged("CartaDos");
            }
        }

        public DelegateCommand Restart
        {
            get
            {
                return _restart;
            }
        }

        public Carta Seleccionada
        {
            get
            {
                return _Seleccionada;
            }

            /// Cuando pulsas mas de 2 cartas verifica si <see cref="CartaDos"/> es nulo, de no ser nulo, significa
            /// que todavia esta comprobando que <see cref="CartaUno"/> y <see cref="CartaDos"/> son iguales.
            /// De no ser nulo se mostrara un dialogo en el que se indicará que no puede pulsar 3 veces seguidas.
            /// IMPORTANTE: Con un booleano para desabilitar los item del gridview no funiona.
            set
            {
                if (CartaDos == null)
                {
                    _Seleccionada = value;

                    //Al reiniciar el juego vuelve a pasar por Seleccionada con value nulo. Ahí sabremos que se ha reiniciado
                    //y nos aprobecharemos para comunicar al jugador que la carga a finalizado.
                    if (Seleccionada != null)
                    {
                        NotifyPropertyChanged("Seleccionada");
                        seleccionadaToCarta();
                    }
                    else
                    {
                        mostrarDialogo("Juego reiniciado, buena suerte!");
                    }

                }
                else
                {
                    mostrarDialogo("No pulse mas de 2 cartas seguidas... Tenga paciencia!");
                }
            }
        }

        private async void mostrarDialogo(string v)
        {
            MessageDialog md = new MessageDialog(v);
            await md.ShowAsync();
        }


        #endregion


        #region Metodos

        /// <summary>
        /// Encargado de mover los valores de Seleccionada a la variable <see cref="CartaUno"/> o <see cref="CartaDos"/>
        /// correspondiente, una vez finalizado a hacer esto checkea si el <see cref="Carta.id"/> son iguales.
        /// Comprueba que <see cref="Seleccionada"/> no este bloqueada, de ser así directamente mostrara un dialogo
        /// en el que dirá que tiene esa carta ya checkeada y visible.
        /// 
        /// Tambien al final del proceso detecta el numero de aciertos para terminar el juego.
        /// <seealso cref=check"/>
        /// <seealso cref="mostrarDialogo(string)"/>
        /// <seealso cref="finJuego"/>
        /// </summary>
        private void seleccionadaToCarta()
        {
            if (!Seleccionada.Block)
            {
                if (CartaUno == null)
                {
                    _Seleccionada.Visible = Windows.UI.Xaml.Visibility.Visible;
                    CartaUno = Seleccionada;
                }
                else if (!Seleccionada.Block)
                {
                    // Perrteneciente a la visibilidad de la cara 2
                    _Seleccionada.Visible = Windows.UI.Xaml.Visibility.Visible;
                    CartaDos = Seleccionada;

                    check();
                }
                if (nAciertos == nAciertoMaximo)
                    finJuego();
            }
            else
            {
                mostrarDialogo("Ya tienes esa carta!");
            }
        }

        private void finJuego()
        {
            mostrarDialogo("Enhorabuena has ganado!!, ha terminado el juego en ");
            restartd_Execute();
        }

        /// <summary>
        /// Metodo encargado de identificar el <see cref="Carta.id"/> y verificar si son o no iguales, de ser así bloquea
        /// las cartas <see cref="Carta.Block"/> para evitar que sean checkeadas nuevamente.
        /// 
        /// Tambien incrementa el contador de aciertos <see cref="nAciertos"/>"/>
        /// <seealso cref="Carta"/>
        /// </summary>
        private void check()
        {
            //Proceso de Checkeo
            if (CartaUno.id == CartaDos.id)
            {
                //Checkeo positivo: Se parecen!
                CartaUno.Block = true;
                CartaDos.Block = true;

                CartaUno = null;
                CartaDos = null;

                nAciertos++;
            }
            else
            {
                //Checkeo Negativo: No se parecen!
                delay();
            }
        }

        //CartaUno y CcartaDos deben ocultarse en este metodo, NO TOCAR.
        private async void delay()
        {
            await Task.Delay(1000);

            CartaUno.Visible = Windows.UI.Xaml.Visibility.Collapsed;
            CartaDos.Visible = Windows.UI.Xaml.Visibility.Collapsed;

            CartaUno = null;
            CartaDos = null;
        }


        #region DelgateCommand

        private bool restart_CanExecute()
        {
            return true;
        }

        private void restartd_Execute()
        {

            CartaUno = null;
            CartaDos = null;

            Lista = Listado.startList();
        }

        #endregion

        #endregion

    }
}
