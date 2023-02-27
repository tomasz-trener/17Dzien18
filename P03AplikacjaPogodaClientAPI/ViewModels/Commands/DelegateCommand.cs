using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P03AplikacjaPogodaClientAPI.ViewModels.Commands
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<object, bool> _canExecute;

        public DelegateCommand(Action execute, Func<object, bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ?
                true : _canExecute(parameter);
        }

        // klikniecie w przyccisk
        public void Execute(object? parameter)
        {
            _execute();
        }
    }
}
