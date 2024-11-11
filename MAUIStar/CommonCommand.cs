using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIStar
{
    public class CommonCommand : ICommand
    {
        private Action<object> executeAction;
        private Func<object, bool> canExecute;

        public CommonCommand(Action<object> executeAction)
        {
            this.executeAction = executeAction;
            this.canExecute = null;
        }

        public CommonCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction?.Invoke(parameter);
        }
    }

}
