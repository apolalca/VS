using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Repoductor.Model
{
    public class Pista:INotifyPropertyChanged      
    {
        private string _Nombre_Cancion;
        private string _Nombre_Artista;
        private string _Genero;
        private string _url;

        public event PropertyChangedEventHandler PropertyChanged;

        public Pista()
        {
            _Nombre_Artista = "";
            _Nombre_Cancion = "";
            _Genero = "";
        }

        public Pista(string Nombre_Cancion, string Nombre_Artista, string Genero, string url)
        {
            _Nombre_Cancion = Nombre_Cancion;
            _Nombre_Artista = Nombre_Artista;
            _Genero = Genero;
            _url = url;
        }

        public string Nombre_Cancion
        {
            set
            {
                _Nombre_Cancion = value;
                OnPropietyChange("Nombre_Cancion");
            }
            get
            {
                return _Nombre_Cancion;
            }
        }

        public string url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                OnPropietyChange("url");
            }
        }

        public string Nombre_Artista
        {
            set
            {
               _Nombre_Artista = value;
                OnPropietyChange("Nombre_Artista");
            }
            get
            {
                return _Nombre_Artista;
            }
        }

        public string Genero
        {
            set
            {
                _Genero = value;
                OnPropietyChange("Genero");
            }
            get
            {
                return _Genero;
            }
        }

        protected void OnPropietyChange(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }

        }

    }
}
