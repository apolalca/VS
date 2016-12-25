using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCartas.Model
{
    //Puede llegar a pertenecer a BL porque es un requisito de la empresa que las cartas sean aleatorias
    // pero para simplificar el proyecto tendremos en cuenta que debe ir en la BL pero lo dejaremos aquí.
    public static class Listado
    {
        private static ObservableCollection<Carta> listado;

        public static ObservableCollection<Carta> startList()
        {
            Random aleatorio = new Random();
            int n;
            bool[] nYaSalidos;

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

            nYaSalidos = new bool[aux.Count];

            //Dara vueltas hasta que nIntroducido tome un valor de 12, en ese momento quedrá decir que ha introducido las 12 cartas en listado satisfactoriamente
            // y podrá salir.
            for (int i = 0; nIntroducido < aux.Count; i++)
            {
                n = aleatorio.Next(0, aux.Count);

                if (!nYaSalidos.ElementAt(n))
                {
                    nIntroducido++;
                    listado.Add(aux.ElementAt(n));
                    nYaSalidos[n] = true;
                }

            }

            return listado;
        }
    }
}
