using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPersonas_Ent
{
    /// <summary>
    /// 
    /// </summary>
    public class clsPersona
    {
        //Atributos
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        
        public String Direccion { get; set; }
        public String Telefono { get; set; }

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
    }
}
