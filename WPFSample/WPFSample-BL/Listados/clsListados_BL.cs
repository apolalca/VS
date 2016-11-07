using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample;
using WPFSample_Ent;
using WPFSample_DAL.Listados;

namespace WPFSample_BL.Listados
{
    public class clsListados_BL
    {
        public List<clsPersona> getListadoPersonasBL()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsListados_DAL miLista = new clsListados_DAL();
            lista = miLista.getListadoPersonasDAL();
            return lista;
        } //Fin List
    } //Fin class clsListados_BL
}
