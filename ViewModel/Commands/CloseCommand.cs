using System;
using System.Windows.Input;

namespace Invoices.ViewModel.Commands {
    class CloseCommand : ICommand {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public CloseCommand(MainWindowViewModel mainWindowViewModel) {
            MainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            MainWindowViewModel.Close(parameter);
        }
    }
}
