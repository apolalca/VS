using DataBlinding_13.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DataBlinding_13.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;
        private DelegateCommand _comandoEliminar;
        private string _textoAbuscar;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageVM()
        {
            _listado = new ListadoPersona().listaPerona();
        }

        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }
        }

        public string textoAbuscar
        {
            get
            {
                return _textoAbuscar;
            }
            set
            {
                _textoAbuscar = value;
            }
        }

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                _comandoEliminar.RaiseCanExecuteChanged();
                OnPropertyChanged("personaSeleccionada");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void btnEliminar(object sender, RoutedEventArgs e)
        {
            listado.Remove(personaSeleccionada);
        }

        public bool EliminarCommand_CanExecute()
        {
            bool sePuedeEliminar = true;

            if (_personaSeleccionada == null)
                sePuedeEliminar = false;

            return sePuedeEliminar;
        }

        public DelegateCommand comandoEliminar
        {
            get
            {
                _comandoEliminar = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                return _comandoEliminar;
            }
        }

        private void EliminarCommand_Executed()
        {
            listado.Remove(personaSeleccionada);
        }
    }
}
