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
        // Lista secundaría donde guardar las coincidencias del filtrado del autoSuggesBox
        private ObservableCollection<Pista> _lstFiltrada;
        private string _textoBuscar;
        public event PropertyChangedEventHandler PropertyChanged;
        private DelegateCommand _eliminarPista;
        private DelegateCommand _actualizarLista;
        #endregion



        #region "Constructores"
        /// <summary>
        /// Constructor por defecto, se encarga de inicializar el listado.
        /// </summary>
        public MainPageVM()
        {
            _lista =  Listado.lista_canciones();
            _lstFiltrada = Listado.lista_canciones();
            //Important!
            _eliminarPista = new DelegateCommand(EliminarPista_Execute, EliminarPista_CanExecute);
            _actualizarLista = new DelegateCommand(BuscarPista_Execute, BuscarPista_CanExecute);
        }

        #endregion



        #region "Propiedades"

        /// <summary>
        /// Devuelve el texto por el cual se desea filtrat.
        /// </summary>
        public string textoBuscar
        {
            set
            {
                _textoBuscar = value;
                ActualizarLista();
            }
            get
            {
                return _textoBuscar;
            }
        }

        /// <summary>
        /// Devuelve una lista de <see cref="ObservableCollection{Pista}"/>
        /// </summary>
        public ObservableCollection<Pista> listado
        {
            get
            {
                return _lista;
            }

            set
            {
                _lista = value;
                NotifyPropertyChanged("listado");
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
        /// Actualiza la lista filtrandola por el <see cref="_textoBuscar"/> y la introduce en <see cref="listado"/>.
        /// De no ser asu y estar <see cref="_textoBuscar"/> vacio volvera a rellenar <see cref="listado"/>.
        /// </summary>
        private void ActualizarLista()
        {

            if (!string.IsNullOrEmpty(_textoBuscar))
            {
                listado = new ObservableCollection<Pista>();
                // Si no esta vacio se filtra y se vuelve a introducir en la variable listado
                var lst = _lstFiltrada.Where(x => x.Nombre_Artista.StartsWith(_textoBuscar));

                // Si encuentra algo lo mete en el listado, de no ser asi crea un pista con informacion de no encontrado.
                if (lst.Count<Pista>() != 0)
                    listado = new ObservableCollection<Pista>(lst);
                else
                    (listado = new ObservableCollection<Pista>()).Add(new Pista("No found", "", "", ""));

            } else
            {
                // Si esta vacio se introduce de nuevo el listado completo
                listado = Listado.lista_canciones();
            }
        }

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
        /// Elimina de la lista una pista.
        /// </summary>
        /// <param name="p">Pista seleccionada que se va a eliminar</param>
        public void eliminar(Pista p)
        {
            _lista.Remove(p);
        }

        #region "DeleteCommand Metodos"

        /// <summary>
        /// Al parecer no deja poner un true habria que sobrecargar el constructor, asi que se ha decidido crear este metodo por sencillex y rapidez
        /// antes que crear dicho metodo y toparnos con problemas inesperados.
        /// </summary>
        /// <returns>boolean siempre true</returns>
       private bool BuscarPista_CanExecute()
        {
            return true;
        }

        /// <summary>
        /// Ejecuta el metodo que filtrará la lista.
        /// </summary>
        private void BuscarPista_Execute()
        {
            // Aqui va una copia de ActualizarLista para evitar copia de codigo y seguir la logica de encapsular llamaremos al metodo
            ActualizarLista();
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

        #endregion

        #endregion
    }
}
