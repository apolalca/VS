using WPFSample_DAL.Manejadoras;
using WPFSample_Ent;

namespace WPFSample_BL.Manejadoras
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
    }
}
