using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPSoundBoard.Model;

namespace UWPSoundBoard.ViewModel
{
    public class ManejadoraSonido : VMBase
    {
        private ObservableCollection<Sonido> _lista;
        private ObservableCollection<MenuItem> _menu;

        public ManejadoraSonido()
        {
            _lista = ListSound.getSounds();
            _menu = ListSound.getMenu();
        }

        public void getSoundByCateg(CategoryAnim categoria, ObservableCollection<Sonido> sonidos)
        {
            sonidos = ListSound.getSounds();
            //Ya que no sabemos que devolvera DEBE estar con VAR
            var sonidosCat = sonidos.Where(x => x.categoria == categoria).ToList();

            sonidos.Clear(); //Limpiamos el array para liego meter los filtrados
            sonidosCat.ForEach(s => sonidos.Add(s));


        }

        public ObservableCollection<MenuItem> Menu
        {
            get
            {
                return _menu;
            }

            set
            {
                _menu = value;
                NotifyPropertyChanged("Menu");
            }
        }

        public ObservableCollection<Sonido> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                _lista = value;
                NotifyPropertyChanged("Lista");
            }
        }


    }
}
