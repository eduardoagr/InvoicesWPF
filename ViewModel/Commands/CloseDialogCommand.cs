using System;
using System.Windows;
using System.Windows.Input;

namespace Invoices.ViewModel.Commands {
    class CloseDialogCommand : ICommand {

        public InputViewModel InputViewModel { get; set; }

        public CloseDialogCommand(InputViewModel inputViewModel) {
            InputViewModel = inputViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            InputViewModel.CloseDialog(parameter as Window);
        }
    }
}
