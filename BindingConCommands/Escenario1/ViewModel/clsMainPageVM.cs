using Repoductor.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoductor.ViewModel
{
    public class MainPageVM: VMBase
    {
        #region "Atributos"
        private Pista _pistaSeleccionada;
        private ObservableCollection<Pista> _lista;
        public event PropertyChangedEventHandler PropertyChanged;
        private DelegateCommand _eliminarPista;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor por defecto, se encarga de inicializar el listado.
        /// </summary>
        public MainPageVM()
        {
            _lista =  Listado.lista_canciones();

            //Important!
            _eliminarPista = new DelegateCommand(EliminarPista_Execute, EliminarPista_CanExecute);
        }

        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve una lista de <see cref="ObservableCollection{Pista}"/>
        /// </summary>
        public ObservableCollection<Pista> listado
        {
            get
            {
                return _lista;
            }
        }

        /// <summary>
        /// Guarda el valor del item de <see cref="_lista"/> seleccionado.
        /// </summary>
        public Pista pistaSeleccionada
        {
            set
            {
                _pistaSeleccionada = value;
                //IMPORTANTE! Indica que se puede ejecutar el Command!
                _eliminarPista.RaiseCanExecuteChanged();
                NotifyPropertyChanged("pistaSeleccionada");
            }

            get
            {
                return _pistaSeleccionada;
            }
        }

        /// <summary>
        /// Obtendremos el valor de <see cref="_eliminarPista"/> para saber si se puede o no activar el command.
        /// <seealso cref="DelegateCommand"/>
        /// </summary>
        public DelegateCommand eliminarPista
        {
            get
            {
                return _eliminarPista;
            }
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Cuando la propiedad cambie será noticado a <see cref="PropertyChanged"/>.
        /// <seealso cref="VMBase"/> & <seealso cref="INotifyPropertyChanged"/>
        /// </summary>
        /// <param name="v">cadena de entrada, la cadena debe ser igual que el nombre del metodo.</param>
        /// <remarks>La cadena de entrada debe ser igual al nombre</remarks>
         [Obsolete("Este metodo esta obsoleto por favor use la clase DelegateCommand(NotifyPropertyChanged).")]
        private void OnPropietyChange(string v)
        {
            // Invocacion automatica equivale a:
            // if (handler != null)
            //      handler(this, new PropertyChangedEventArgs(v));
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));

        }

        /// <summary>
        /// Comprueba si se puede ejecutar el comando para eliminar dicha pista, en caso de no haber seleccionado ninguna no se podrá usar.
        /// <seealso cref="DelegateCommand"/>
        /// </summary>
        /// <returns>true si es valida y se puede activar, false si no se ha seleccionado a nadie y no se puede validar</returns>
        private bool EliminarPista_CanExecute()
        {
            return _pistaSeleccionada != null ? true : false;
        }

        /// <summary>
        /// Ejecutara el borrado y la eliminara de la <see cref="listado"/>.
        /// <seealso cref="DelegateCommand"/> && <seealso cref="Listado"/>
        /// </summary>
        private void EliminarPista_Execute()
        {
            listado.Remove(_pistaSeleccionada);
            _pistaSeleccionada = null;
        }

        /// <summary>
        /// Elimina de la lista una pista.
        /// </summary>
        /// <param name="p">Pista seleccionada que se va a eliminar</param>
        public void eliminar(Pista p)
        {
            _lista.Remove(p);
        }

        #endregion
    }
}
