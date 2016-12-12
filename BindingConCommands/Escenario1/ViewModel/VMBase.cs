using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repoductor.ViewModel
{
    public abstract class VMBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Si hay sobrecarga en <see cref="PropertyChanged"/> invocamos su instancia.
        /// </summary>
        /// <remarks>El <see cref="propieryName"/>debe ser igual que el nombre de la propiedad</remarks>
        /// <param name="propieryName"></param>
        protected virtual void NotifyPropertyChanged(string propieryName = null)
        {
            //Linq expresion 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propieryName));
        }
    }
}
