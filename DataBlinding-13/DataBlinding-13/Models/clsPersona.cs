using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBlinding_13.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class clsPersona : INotifyPropertyChanged
    {
        //Atributos

        private String _Nombre;
        private String _Apellidos;
        private String _Direccion;
        private DateTime _FechaNac;
        private String _Telefono;
        public int ID { get; set; }

        [Required]
        public String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        [Required]
        public String Apellidos {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
                OnPropertyChanged("Apellidos");
            }
        }

        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime FechaNac {
            get
            {
                return _FechaNac;
            }

            set
            {
                _FechaNac = value;
                OnPropertyChanged("FechaNac");
            }
                
        }
        
        public String Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
                OnPropertyChanged("Direccion");
            }
        }
        public String Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
                OnPropertyChanged("Telefono");
            }
        }

        //Constructor por defecto
        public clsPersona()
        {
            this.ID = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNac = new DateTime();
            this.Direccion = "";
            this.Telefono = "";
        }

        //Constructor por parámetros
        public clsPersona (int id, String nombre, String apellidos, DateTime fechaNac, String direccion, String telefono)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
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
