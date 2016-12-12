using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario2.Model
{
    public class Trilogia
    {
        #region "Atributos"

        private string _Nombre_Trilogia;
        private string _Año_Trilogia;
        private ObservableCollection<Pelicula> _peliculas;

        #endregion

        #region "Constructores"

        public Trilogia()
        {
            _peliculas = new ObservableCollection<Pelicula>();
        }

        public Trilogia(ObservableCollection<Pelicula> peliculas)
        {
            _peliculas = new ObservableCollection<Pelicula>(peliculas);
        }

        public Trilogia(string Nombre_Trilogia, string Año_Trilogia, ObservableCollection<Pelicula> peliculas)
        {
            _peliculas = new ObservableCollection<Pelicula>(peliculas);
            this._Nombre_Trilogia = Nombre_Trilogia;
            this._Año_Trilogia = Año_Trilogia;
        }

        #endregion

        #region "Propiedades"

        public string Nombre_Trilogia
        {
            get
            {
                return _Nombre_Trilogia;
            }

            set
            {
                _Nombre_Trilogia = value;
            }
        }

        public string Año_Trilogia
        {
            get
            {
                return _Año_Trilogia;
            }

            set
            {
                _Año_Trilogia = value;
            }
        }

        public ObservableCollection<Pelicula> Peliculas
        {
            get
            {
                return _peliculas;
            }
            set
            {
                _peliculas = value;
            }
        }

        #endregion

    }
}
