using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WPFPersonas_Ent
{
    public class clsListado
    {
        public ObservableCollection<clsPersona> getListado()
        {
            ObservableCollection<clsPersona> lista = new ObservableCollection<clsPersona>();
            
            lista.Add(new clsPersona(1,"David", "Benítez Rasero", new DateTime(1996,1,23),"adfhilaubaelr","666666666"));
            lista.Add(new clsPersona(2,"Makoto", "Naegi", new DateTime(2000, 5, 26), "asfhglaerfgo", "999999999"));
            lista.Add(new clsPersona(3,"Sayaka", "Maizono", new DateTime(2000, 7, 2), "adjklfhbl", "888888888"));
            lista.Add(new clsPersona(4,"Kyouko", "Kirigiri", new DateTime(2000, 4, 15), "dkfhbsdlf", "555555555"));
            lista.Add(new clsPersona(5, "Celestia", "Ludenberg", new DateTime(2000, 1, 4), "adfhilaubaelr", "666666666"));
            lista.Add(new clsPersona(6, "Chiaki", "Nanami", new DateTime(2000, 4, 23), "asfhglaerfgo", "999999999"));
            lista.Add(new clsPersona(7, "Nagito", "Komaeda", new DateTime(2000, 7, 18), "adjklfhbl", "888888888"));
            lista.Add(new clsPersona(8, "Hinata", "Hajime", new DateTime(2000, 4, 15), "dkfhbsdlf", "555555555"));
            lista.Add(new clsPersona(9, "Junko", "Enoshima", new DateTime(1996, 1, 23), "adfhilaubaelr", "666666666"));
            lista.Add(new clsPersona(10, "Sakura", "Oogami", new DateTime(2000, 5, 26), "asfhglaerfgo", "999999999"));
            lista.Add(new clsPersona(11, "Aoi", "Asahina", new DateTime(2000, 7, 2), "adjklfhbl", "888888888"));
            lista.Add(new clsPersona(12, "Touko", "Fukawa", new DateTime(2000, 4, 15), "dkfhbsdlf", "555555555"));

            return lista;
        }
    }
}