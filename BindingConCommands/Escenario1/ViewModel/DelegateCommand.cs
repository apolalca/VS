using System;
using System.Windows.Input;

namespace Repoductor.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Inicializa una nueva instancia para DelegateCommand que siempre se puede ejecutar 
        /// <seealso cref="RelayCommand"/>
        /// </summary>
        /// <param name="execute"></param>
        public DelegateCommand(Action execute) : this(execute, null) { }


        /// <summary>
        /// Incializa una instancia para DelegateCommand.
        /// </summary>
        /// <param name="execute">Ejecucion logica</param>
        /// <param name="canExecute">Estado de la ejecucion logica</param>
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Este metodo define y determina cuando el comando se puede ejecutar
        /// </summary>
        /// <param name="parameter">Este parametro siempre será ignorado</param>
        /// <returns>La salida a true signifiara que se puede ejecutar</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        /// <summary>
        /// Define el metodo a llamar cuando el comando es invocado.
        /// </summary>
        /// <param name="parameter">este parametro siempre sera ignorado</param>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
                _execute();
        }

        /// <summary>
        /// Sobrecarga de <see cref="CanExecuteChanged"/> evento
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
