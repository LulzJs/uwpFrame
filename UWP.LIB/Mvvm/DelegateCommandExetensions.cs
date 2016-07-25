using System.Collections.Generic;
using System.Windows.Input;

namespace UWP.LIB
{
    static class DelegateCommandExetensions
    {
        public static void RaiseCanExecuteChanged(this ICommand self)
        {
            var delegateCommand = self as DelegateCommand;
            if (delegateCommand == null)
            {
                return;
            }

            delegateCommand.RaiseCanExecuteChanged();
        }

        public static void RaiseCanExecuteChanged(this IEnumerable<ICommand> self)
        {
            foreach (var command in self)
            {
                command.RaiseCanExecuteChanged();
            }
        }
    }
}