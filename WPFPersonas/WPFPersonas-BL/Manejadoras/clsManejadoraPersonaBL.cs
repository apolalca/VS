using WPFPersonas_DAL.Manejadoras;
using WPFPersonas_Ent;


namespace WPFPersonas_BL.Manejadoras
{
    public class clsManejadoraPersonaBL
    {
        private clsManejadoraPersonaDAL manejadoraPersona;

        public clsManejadoraPersonaBL()
        {
            manejadoraPersona = new clsManejadoraPersonaDAL();
        }

        public int insertPersona(clsPersona persona)
        {
            int result;
            result = manejadoraPersona.insertarPersonaDAL(persona);
            return result;
        }

        public int borrarPersona(int id)
        {
            int resultado;
            resultado = manejadoraPersona.borrarPersonaDAL(id);
            return resultado;
        }

        public int actualizarPersona(clsPersona persona)
        {
            int resultado;
            resultado = manejadoraPersona.actualizarPersona(persona);
            return resultado;
        }

        public clsPersona getPersona(int id)
        {
            return manejadoraPersona.getPersona(id);
        }
    }
}
