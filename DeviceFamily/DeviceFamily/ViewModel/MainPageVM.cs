using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceFamily.Model;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;
using DeviceFamily.ViewModels;


//https://msdn.microsoft.com/en-us/library/hh821028.aspx
//https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlMasterDetail

namespace DeviceFamily.ViewModel
{
    public class MainPageVM : VMBase
    {
        private Persona _personaSeleccionada;
        private ObservableCollection<Persona> _listado;
        private DelegateCommand _guradarCommand;
        private DelegateCommand _addNewCommand;
        private DelegateCommand _borrarcommand;
        private DelegateCommand _buscarCommand;
        private PersonaManager manejadoraPersona;

        public MainPageVM()
        {
            rellenarListado();
            manejadoraPersona = new PersonaManager();
            _addNewCommand = new DelegateCommand(AddNewCommand_Exceute);
            _guradarCommand = new DelegateCommand(GuardarCommand_Execute, GuardarCommand_CanExecute);
            ///TODO _borrarcommand = new DelegateCommand()
            _borrarcommand = new DelegateCommand(BorrarrCommand_Excecute, BorrarCommand_CanExecute);
        }

        #region Atributos

        public ObservableCollection<Persona> Lista
        {
            set
            {
                _listado = value;
                NotifyPropertyChanged("Lista");
            }
            get
            {
                return _listado;
            }
        }

        public Persona PersonaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                _addNewCommand.RaiseCanExecuteChanged();
                _borrarcommand.RaiseCanExecuteChanged();
                _guradarCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("PersonaSeleccionada");
            }
        }

        public DelegateCommand BorrarCommand
        {
            get
            {
                return _borrarcommand;
            }
        }

        public DelegateCommand GuardarCommand
        {
            get
            {
                return _guradarCommand;
            }
        }

        public DelegateCommand AddNewCommand
        {
            get
            {
                return _addNewCommand;
            }
        }

        #endregion

        #region Metodos

        #region DelegatedCommand

        /// <summary>
        /// Cuando pulsemos ek boton añadir, crearemos una nueva persona con id 0 para que el sistema sepa que es uno nuevo.
        /// </summary>
        private void AddNewCommand_Exceute()
        {
            PersonaSeleccionada = new Persona();
        }

        /// <summary>
        /// Si la persona es diferente a null puede ejecutarse
        /// </summary>
        /// <returns></returns>
        private bool GuardarCommand_CanExecute()
        {
            bool exc = false;

            if (PersonaSeleccionada != null)
                exc = true;

            return exc;
        }


        /// <summary>
        /// Si el ID de la persona es 0 se hará un post el cual meterá una persona nueva
        /// </summary>
        private async void GuardarCommand_Execute()
        {
            HttpStatusCode status;

            if (PersonaSeleccionada.id == 0)
                status = await manejadoraPersona.postPersona(PersonaSeleccionada);
            else
                status = await manejadoraPersona.putPersona(PersonaSeleccionada);

            //Normalmente el error suele darse con el else, pero aqui lo ponemos como primera condicion ya qye BadRequest
            // es el error que suelta los dos metodos anteriores.
            if (status == HttpStatusCode.BadRequest)

                mostrarError("Se ha producido un error a la hora de guardar");
            else
            {
                //Decision persona, PersonaSeleccioanda se quedará en null y en caso de ser movil volverá a MainPage
                PersonaSeleccionada = null;
                rellenarListado();
            }

        }

        /// <summary>
        /// Si la persona es nullo o es 0 no puede eliminar.
        /// </summary>
        /// <returns></returns>
        private bool BorrarCommand_CanExecute()
        {
            bool exc = false;

            if (!(_personaSeleccionada == null || _personaSeleccionada.id == 0))
                exc = true;

            return exc;
        }

        /// <summary>
        /// Pregunta si queremos eliminar con un <see cref="ContentDialog"/>, de ser así llamaremos
        /// a <see cref="PersonaManager.deletePersona(int)"/>
        /// 
        /// <seealso cref="HttpStatusCode"/>
        /// </summary>
        private async void BorrarrCommand_Excecute()
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Eliminar";
            dialog.Content = "¿Desea borrar a ?" + _personaSeleccionada.nombre;
            dialog.PrimaryButtonText = "Cancelar";
            dialog.SecondaryButtonText = "Aceptar";

            ContentDialogResult res = await dialog.ShowAsync();

            if (res == ContentDialogResult.Secondary)
            {
                HttpStatusCode status = await manejadoraPersona.deletePersona(PersonaSeleccionada.id);

                //Si devuelve un status correcto se prosigue con los pasos, en el caso contrario se rellenaria otro dialogo
                // con el error.
                if (status == HttpStatusCode.Accepted)
                {
                    PersonaSeleccionada = null;
                    rellenarListado();
                } else
                {
                    mostrarError("Se ha producido un error a la hora de borrar"); 
                }
            }
        }

        #endregion

        /// <summary>
        /// Encargado de rellenar el listado desde la base de datos.
        /// </summary>
        private async void rellenarListado()
        {
            Lista = await new Listado().getList();
            NotifyPropertyChanged("Lista");
        }

        /// <summary>
        /// Encargado de mostrar un dialogo de error. Siempre aparecerá el texto y el <see cref="Persona.nombre"/>
        /// </summary>
        /// <param name="str">Cadena de texto que mostrara el dialogo.</param>
        private async void mostrarError(string str)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Error";
            dialog.Content = str + PersonaSeleccionada.nombre;
            await dialog.ShowAsync();
        }

        ///TODO queda por hacer un buscar Command que busque y filtre los datos.

        #endregion


    }
}
