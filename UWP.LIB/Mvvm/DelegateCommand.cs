using System;
using System.Windows.Input;

namespace UWP.LIB
{
    public class DelegateCommand : ICommand
    {
        private static readonly Action<object> EmptyExecute = param => { };
        private static readonly Func<object, bool> EmptyCanExecute = param => true;

        private Action<object> execute;
        private Func<object, bool> canExecute;

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? EmptyExecute;
            this.canExecute = canExecute ?? EmptyCanExecute;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            Execute(parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            var h = this.CanExecuteChanged;
            h?.Invoke(this, EventArgs.Empty);
        }


    }
}