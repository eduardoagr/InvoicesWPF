using Invoices.Model;

using System;
using System.Windows;
using System.Windows.Input;

namespace Invoices.ViewModel.Commands {
    class SaveCommand : ICommand {

        public InputViewModel InputViewModel { get; set; }

        public SaveCommand(InputViewModel inputViewModel) {
            InputViewModel = inputViewModel;
        }

        public event EventHandler CanExecuteChanged;


        public bool CanExecute(object parameter) {

            return true;
        }

        public void Execute(object parameter) {
            InputViewModel.Save(parameter as Window);
        }
    }
}
