using Escenario2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario2.ViewModel
{
    public class MainPageVM : BaseVM
    {
        private ObservableCollection<Trilogia> _lst;
        private Trilogia _Trilogia_Seleccionada;
        private Pelicula _Pelicula_Seleccionada;
        private Personaje _Personaje_Seleccionado;

        public MainPageVM()
        {
            ListadoTrilogiaClasica listado = new ListadoTrilogiaClasica();
            
            _lst = new ObservableCollection<Trilogia>(listado.Trilogias);
            
        }

        public ObservableCollection<Trilogia> Trilogias
        {
            get
            {
                return _lst;
            }
            set
            {
                _lst = value;
                NotifyPropertyChanged("Trilogias");
            }
        }

        public Trilogia Trilogia_Seleccionada
        {
            get
            {
                return _Trilogia_Seleccionada;
            }

            set
            {
                _Trilogia_Seleccionada = value;
                NotifyPropertyChanged("Trilogia_Seleccionada");
            }
        }

        public Pelicula Pelicula_Seleccionada
        {
            get
            {
                return _Pelicula_Seleccionada;
            }
            set
            {
                _Pelicula_Seleccionada = value;
                NotifyPropertyChanged("Pelicula_Seleccionada");
            }
        }

        public Personaje Personaje_Seleccionado
        {
            set
            {
                _Personaje_Seleccionado = value;
                NotifyPropertyChanged("Personaje_Seleccionado");
            }
            get
            {
                return _Personaje_Seleccionado;
            }
        }
    }
}
