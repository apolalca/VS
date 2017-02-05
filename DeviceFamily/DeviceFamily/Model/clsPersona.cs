using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFamily.Model
{
    public class Persona: INotifyPropertyChanged
    {

        private string _Nombre;
        private string _Apellido;
        private DateTime? _FechaNac;
        private string _Telefono;
        private string _Direccion;
        private int _id;

        public event PropertyChangedEventHandler PropertyChanged;

        //constructores
        public Persona(string nombre, string apellido, DateTime fechaNac, string telefono, string direccion)
        {

            this._Nombre = nombre;
            this._Apellido = apellido;
            this._FechaNac = fechaNac;
            this._Telefono = telefono;
            this._Direccion = direccion;

        }

        public Persona()
        {
            this._id = 0;
            this._Nombre = "";
            this._Apellido = "";
            this._FechaNac = new DateTime();
            this._Telefono = "";
            this._Direccion = "";
        }



        public string nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                this._Nombre = value;
                OnPropertyChanged("nombre");
            }
        }

        public string apellido
        {
            get
            {
                return _Apellido;
            }
            set
            {
                this._Apellido = value;
                OnPropertyChanged("apellido");
            }
        }



        public object fechaNac
        {
            get
            {
                return this._FechaNac;
            }
            set
            {
                //Solucion encontrada por Dani: Lo que recoge es un tipo o string o DATETIME, para acabar con el error tenemos que
                // cambir el tipo de DateTime a object y completar con el cambio.
                if (value.GetType() == typeof(string))
                {

                    this._FechaNac = Convert.ToDateTime((String)value);
                }

                else
                {
                    this._FechaNac = (DateTime)value;
                }



                OnPropertyChanged("fechaNac");
            }
        }

        public string telefono
        {
            get
            {
                return this._Telefono;
            }
            set
            {
                this._Telefono = value;
                OnPropertyChanged("telefono");
            }
        }

        public string direccion
        {
            get
            {
                return this._Direccion;
            }
            set
            {
                this._Direccion = value;
                OnPropertyChanged("direccion");
            }
        }

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}
