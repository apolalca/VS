using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPersonas_DAL.Listados;
using WPFPersonas_Ent;

namespace WPFPersonas_BL.Listados
{
    public class clsListados_BL
    {
        public ObservableCollection<clsPersona> getListadoPersonasBL()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();
            clsListados_DAL miLista = new clsListados_DAL();
            lista = miLista.getListadoPersonasDAL();
            return lista;
        } //Fin List
    } //Fin class clsListados_BL
}
