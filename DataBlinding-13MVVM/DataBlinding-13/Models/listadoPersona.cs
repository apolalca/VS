using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBlinding_13.Models
{
    class ListadoPersona
    {
        private ObservableCollection<clsPersona> listadoPersonas;

        public ListadoPersona()
        {
            listadoPersonas = new ObservableCollection<clsPersona>();
            rellenarListado();
        }

        private void rellenarListado()
        {
            listadoPersonas.Add(new clsPersona(1, "Adrian", "Pol", new DateTime(1994, 11, 16), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(2, "asdasd", "Perez", new DateTime(1999, 11, 23), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(3, "asfaf", "Geraldo", new DateTime(1994, 04, 25), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(4, "asdasd", "asdda", new DateTime(1995, 02, 20), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(5, "Luis", "dfasf", new DateTime(1992, 05, 07), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(6, "Marco", "asd", new DateTime(1986, 04, 09), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(7, "Paco", "Sanchez", new DateTime(1990, 07, 11), "Calle S/N", "66787654"));
            listadoPersonas.Add(new clsPersona(8, "Antonio", "jhah", new DateTime(1992, 11, 01), "Calle S/N", "66787654"));
        }

        public ObservableCollection<clsPersona> listaPerona()
        {
            return listadoPersonas;
        }
    }
}
