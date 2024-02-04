using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginWpfMVVM.Infrastructures
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _CanExecute;


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _CanExecute = canExecute;
        }

        public RelayCommand(Func<object, bool> canExecute = null)
        {
            _CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute == null || _CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if (_execute != null)
            {
                _execute(parameter);
            }
        }
    }
}
