using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario2.Model
{
    public class Pelicula 
    {
        #region "Atributos"
        private string _Nombre_Pelicula;
        private string _Año_Pelicula;
        private ObservableCollection<Personaje> _personajes;
        #endregion

        #region "Constructores"

        public Pelicula()
        {
            _personajes = new ObservableCollection<Personaje>();
        }

        public Pelicula(ObservableCollection<Personaje> personajes)
        {
            _personajes = new ObservableCollection<Personaje>(personajes);
        }

        public Pelicula(string Nombre_Pelicula, string Año_Pelicula, ObservableCollection<Personaje> personaje)
        {
            _personajes = new ObservableCollection<Personaje>(personaje);
            this._Nombre_Pelicula = Nombre_Pelicula;
            this._Año_Pelicula = Año_Pelicula;
        }

        #endregion

        #region "Propiedades"

        public string Nombre_Pelicula
        {
            get
            {
                return _Nombre_Pelicula;
            }

            set
            {
                _Nombre_Pelicula = value;
            }
        }

        public string Año_Pelicula
        {
            get
            {
                return _Año_Pelicula;
            }

            set
            {
                _Año_Pelicula = value;
            }
        }

        public ObservableCollection<Personaje> Personajes
        {
            get
            {
                return _personajes;
            }

            set
            {
                _personajes = value;
            }
        }

        #endregion

    }
}
