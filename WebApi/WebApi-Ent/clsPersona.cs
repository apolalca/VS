using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Ent
{
    /// <summary>
    /// 
    /// </summary>
    public class Persona
    {
        //Atributos
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNac { get; set; }    
        public String Direccion { get; set; }
        public String Telefono { get; set; }

        //Constructor por defecto
        public Persona()
        {
            this.id = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNac = new DateTime();
            this.Direccion = "";
            this.Telefono = "";
        }

        //Constructor por parámetros
        public Persona (int id, String nombre, String apellidos, DateTime fechaNac, String direccion, String telefono)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
