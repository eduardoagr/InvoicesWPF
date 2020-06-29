
using System;
using System.Windows;
using System.Windows.Input;

namespace Invoices.ViewModel {
    class OpenDialogCommand : ICommand {

        public MainWindowViewModel MainWindowViewModel { get; set; }

        public OpenDialogCommand(MainWindowViewModel mainWindowViewModel) {
            MainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {

            return true;
        }

        public void Execute(object parameter) {
            MainWindowViewModel.OpenDialog(parameter as Window);
        }
    }
}
