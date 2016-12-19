using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ExamenCartas.Model
{
    public class Carta : INotifyClass
    {
        private string _img;
        private string _nombre;
        private int _id;
        private Visibility _visible;

        public Carta() { }

        public Carta(string img, int id)
        {
            this._img = img;
            this._id = id;
            _visible = Visibility.Collapsed;
        }

        public Carta(string img, string nombre, int id)
        {
            this._img = img;
            this._nombre = nombre;
            this._id = id;
            this._visible = Visibility.Collapsed;
        }

        public Visibility Visible
        {
            get
            {
                return _visible;
            }
            set
            {
                _visible = value;
                NotifyPropertyChanged("Visible");
            }
        }

        public string img
        {
            get
            {
                return _img;
            }
            set
            {
                _img = value;
            }
        }

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}
