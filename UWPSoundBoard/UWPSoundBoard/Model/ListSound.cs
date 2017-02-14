using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public static class ListSound
    {
        public static  ObservableCollection<Sonido> getSounds()
        {
            ObservableCollection<Sonido> sonidos = new ObservableCollection<Sonido>();

            sonidos.Add(new Sonido("cat", CategoryAnim.Animales));

            return sonidos;
        }

        public static ObservableCollection<MenuItem> getMenu()
        {
            ObservableCollection<MenuItem> menus = new ObservableCollection<MenuItem>();

            menus.Add(new MenuItem { img = "Assets/img/Animales/cat.png", categoria = CategoryAnim.Animales });

            return menus;
        }
    }
}
