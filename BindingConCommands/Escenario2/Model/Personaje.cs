using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario2.Model
{
    public class Personaje
    {

        #region "Atributos"
        private string _Nombre_Personaje;
        private string _Apellido_Personaje;
        private string _Año_Nacimiento;
        private string _Ciudad_Natal;
        #endregion

        #region "Constructores"

        public Personaje()
        {

        }

        public Personaje(string Nombre_Personaje, string Apellido_Personaje, string Año_Nacimiento, string Ciudad_Natal)
        {
            this._Nombre_Personaje = Nombre_Personaje;
            this._Apellido_Personaje = Apellido_Personaje;
            this._Año_Nacimiento = Año_Nacimiento;
            this._Ciudad_Natal = Ciudad_Natal;
        }
        #endregion

        #region "Propiedades"

        public string Nombre_Personaje
        {
            get
            {
                return _Nombre_Personaje;
            }
            set
            {
                _Nombre_Personaje = value;
            }
        }

        public string Apellido_Personaje
        {
            get
            {
                return _Apellido_Personaje;
            }
            set
            {
                _Apellido_Personaje = value;
            }
        }

        public string Año_Nacimiento
        {
            get
            {
                return _Año_Nacimiento;
            }
            set
            {
                _Año_Nacimiento = value;
            }
        }

        public string Ciudad_Natal
        {
            get
            {
                return _Ciudad_Natal;
            }
            set
            {
                _Ciudad_Natal = value;
            }
        }

        #endregion
    }
}
