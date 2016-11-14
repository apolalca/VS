using DataBlinding_13.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBlinding_13.ViewModels
{
    class MainPageVM : INotifyPropertyChanged
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;

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



        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                OnPropertyChanged("personaSeleccionada");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
