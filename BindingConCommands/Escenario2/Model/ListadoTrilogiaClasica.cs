using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario2.Model
{
    /// <summary>
    /// Cargará los listados responsables de cada trilogia seleccionada.
    /// </summary>
    public class ListadoTrilogiaClasica
    {
        private ObservableCollection<Trilogia> _Trilogias;

        #region "Constructores"
        public ListadoTrilogiaClasica()
        {
            CargarTrilogia();
        }
        #endregion

        #region "Propiedades"

        public ObservableCollection<Trilogia> Trilogias
        {
            get
            {
                return _Trilogias;
            }
        }
        #endregion

        #region "Metodos"

        private void CargarTrilogia()
        {
            _Trilogias = new ObservableCollection<Trilogia>();
            Trilogia Clasica = new Trilogia("Clasica", "1977 y 1983", CargarDatosClasica());
            Trilogia Presecuel = new Trilogia("Persecuela", "1977 y 1983", CargarDatosClasica());
            Trilogia Secuela = new Trilogia("Secuela", "1977 y 1983", CargarDatosClasica());
            _Trilogias.Add(Clasica);
            _Trilogias.Add(Secuela);
            _Trilogias.Add(Presecuel);
        }

        private ObservableCollection<Pelicula> CargarDatosClasica()
        {
            ObservableCollection<Pelicula> pelicula_Clasica = new ObservableCollection<Pelicula>();
            ObservableCollection<Personaje> personajes = new ObservableCollection<Personaje>();

            personajes.Add(new Personaje("Luke", "Skywalker", "ms-appx://Escenario2/Assets/music.mp3", "http://img.lum.dolimg.com/v1/images/starwars_551c43f4.jpeg"));
            personajes.Add(new Personaje("Luke", "Skywalker", "ms-appx://Escenario2/Assets/music.mp3", "http://img.lum.dolimg.com/v1/images/starwars_551c43f4.jpeg"));
            personajes.Add(new Personaje("Luke", "Skywalker", "ms-appx://Escenario2/Assets/music.mp3", "http://img.lum.dolimg.com/v1/images/starwars_551c43f4.jpeg"));

            pelicula_Clasica.Add(new Pelicula("Star Wars Episodio IV: Una Nueva Esperanza", "XXX", personajes));
            pelicula_Clasica.Add(new Pelicula("Star Wars Episodio V: El Imperio Contraataca", "XXX", personajes));
            pelicula_Clasica.Add(new Pelicula("Star Wars Episodio VI: El Retorno del Jedia", "XXX", personajes));

            return pelicula_Clasica;
        }
        #endregion
    }
}
