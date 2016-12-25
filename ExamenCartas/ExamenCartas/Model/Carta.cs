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

        /// <summary>
        /// Hemos comprobado que las cartas selecionadas si son correctas se marcan pero si vuelves a marcar una carta 
        ///correcta con otra <see cref="MainPage"/> las dos cartas y como son incorrectas la pone en Collapsed, para arreglar esto
        /// usamos un <see cref="bool"/>para evitar que la vuelva a checkear.
        /// </summary>
        private bool _block;

        public Carta() { }

        public Carta(string img, int id)
        {
            this._img = img;
            this._id = id;
            _visible = Visibility.Collapsed;
            _block = false;
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

        public bool Block
        {
            get
            {
                return _block;
            }
            set
            {
                _block = value;
                NotifyPropertyChanged("Block");
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
