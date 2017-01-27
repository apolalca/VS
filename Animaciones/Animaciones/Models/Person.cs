using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaciones.Models
{
    public class Person
    {
        private String nombre;
        private String apellido;

        public Person(String nombre, String apellido)
        {

        }

        public String Nombre
        {
            set
            {
                this.nombre = value;
            }

            get
            {
                return this.nombre;
            }
        }

        public String Apellido
        {
            set
            {
                this.apellido = value;
            }
            get
            {
                return this.apellido;
            }
        }
    }
}
