using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCartas.Model
{
    public static class Listado
    {
        private static ObservableCollection<Carta> listado;

        public static ObservableCollection<Carta> startList()
        {
            Random aleatorio = new Random();
            int n;
            bool[] nYaSalidos = new bool[11];
           
            listado = new ObservableCollection<Carta>();
            ObservableCollection<Carta> aux = new ObservableCollection<Carta>();
            int nIntroducido = 0; //Contador perteneciente al numero de veces que se ha introducido una carta en listado.

            //Armas
            aux.Add(new Carta("/Assets/AR-15.jpg", 0));
            aux.Add(new Carta("/Assets/Ballesta.jpg", 1));
            aux.Add(new Carta("/Assets/Colt.jpg", 2));
            aux.Add(new Carta("/Assets/Katana.jpg", 3));
            aux.Add(new Carta("/Assets/Lucille.jpg", 4));
            aux.Add(new Carta("/Assets/Martillo.jpg", 5));

            //Personajes
            aux.Add(new Carta("/Assets/Sasha.jpg", 0));
            aux.Add(new Carta("/Assets/Daryl.jpg", 1));
            aux.Add(new Carta("/Assets/Rick.jpg", 2));
            aux.Add(new Carta("/Assets/Michonne.jpg", 3));
            aux.Add(new Carta("/Assets/Negan.jpg", 4));
            aux.Add(new Carta("/Assets/Tyreese.jpg", 5));

            //Dara vueltas hasta que nIntroducido tome un valor de 12, en ese momento quedrá decir que ha introducido las 12 cartas en listado satisfactoriamente
            // y podrá salir.
            // TODO Se repuiten numeros, ultimo codigo tocado el _IsClickOk en MainPage
            for (int i = 0; nIntroducido != 12; i++)
            {
                n = aleatorio.Next(0, aux.Count - 1);

                if (!nYaSalidos.ElementAt(n))
                {
                    nIntroducido++;
                    listado.Add(aux.ElementAt(n));
                }
            
            }

            return listado;
        }

        public static ObservableCollection<Carta> lista
        {
            get
            {
                if (listado == null)
                    throw new Exception("listado no se ha inicializado!");
                return listado;
            }
            set
            {
                listado = value;
            }
        }

    }
}
