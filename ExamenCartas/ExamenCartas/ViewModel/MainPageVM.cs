using ExamenCartas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private bool _IsClickOk;
        //Contador aciertos
        private static int nAciertos;

        #region Constructores

        public MainPageVM()
        {
            _lista = new ObservableCollection<Carta>();
            _lista = Listado.startList();

            _cartaUno = null;
            _cartaDos = null;

            nAciertos = 0;
            _IsClickOk = true;

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

        public bool IsClickOk
        {
            get
            {
                return _IsClickOk;
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
            set
            {
                _Seleccionada = value;
                NotifyPropertyChanged("Seleccionada");
                check();
            }
        }

        #endregion


        #region Metodos

        private void check()
        {
            if (CartaUno == null)
            {
                if (_Seleccionada != null)
                {
                    // Perteneciente a la visibilidad de la carta 1
                    _Seleccionada.Visible = Windows.UI.Xaml.Visibility.Visible;
                    CartaUno = Seleccionada;
                }
            } else
            {
                // Comprobar si selecciona la misma carta
                if (Seleccionada != CartaUno)
                {
                    // Si ha pulsado la segunda carta se bloqueará la opcion de poder clickear una más para evitar entrar en
                    // nulo. 
                    _IsClickOk = false;

                    // Perrteneciente a la visibilidad de la cara 2

                    _Seleccionada.Visible = Windows.UI.Xaml.Visibility.Visible;
                    CartaDos = Seleccionada;

                    if (CartaUno.id == CartaDos.id)
                    {
                        CartaUno = null;
                        CartaDos = null;
                    } else
                    {
                        delay();
                    }
                }
            }
        }

        private async void delay()
        {
            await Task.Delay(1000);
            CartaUno.Visible = Windows.UI.Xaml.Visibility.Collapsed;
            CartaDos.Visible = Windows.UI.Xaml.Visibility.Collapsed;
            CartaUno = null;
            CartaDos = null;

            //Se restablece Click Item.
            _IsClickOk = true;
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
            
            try
            {
                _lista = Listado.lista;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #endregion

    }
}
