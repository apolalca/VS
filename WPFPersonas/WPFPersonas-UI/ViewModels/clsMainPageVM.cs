using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFPersonas_BL.Listados;
using WPFPersonas_BL.Manejadoras;
using WPFPersonas_Ent;

namespace WPFPersonas_UI.ViewModels
{
    public class clsMainPageVM : clsVMBase
    {
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;
        private DelegateCommand _eliminarCommand;

        public clsMainPageVM()
        {
            _listado = new clsListados_BL().getListadoPersonasBL();
            _eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
        }

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                _eliminarCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("personaSeleccionada");
            }
        }
        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }
        }

        public void btnEliminar_Click()
        {
            listado.Remove(personaSeleccionada);
        }

        public DelegateCommand eliminarCommand
        {
            get
            {
                return _eliminarCommand;
            }
        }

        private void EliminarCommand_Executed()
        {
            // Antiguo listado.Remove(personaSeleccionada);

            clsManejadoraPersonaBL manejadora = new clsManejadoraPersonaBL();
                if (MessageBox.Show("¿Desea borrar la persona seleccionada?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                try
                {
                    manejadora.borrarPersona(_personaSeleccionada.ID);
                    _listado = new clsListados_BL().getListadoPersonasBL();
                    NotifyPropertyChanged("listado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw;
                }
                    
                }
            
        }

        private bool EliminarCommand_CanExecute()
        {
            bool puedeBorrar = false;
            if (personaSeleccionada != null)
                puedeBorrar = true;
            return puedeBorrar;
        }
    }
}
