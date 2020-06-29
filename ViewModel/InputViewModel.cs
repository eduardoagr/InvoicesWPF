using Invoices.DatabaseHelpers;
using Invoices.Dialogs;
using Invoices.Model;
using Invoices.ViewModel.Commands;

using System;
using System.Windows;

namespace Invoices.ViewModel {
    class InputViewModel {

        public User User { get; set; }
        public CloseDialogCommand CloseDialogCommand { get; set; }
        public SaveCommand SaveCommand { get; set; }

        public InputViewModel() {
            SaveCommand = new SaveCommand(this);
            CloseDialogCommand = new CloseDialogCommand(this);
            User = new User();
        }


        internal void CloseDialog(Window window) {
            window.Close();
            Operation.Read();
        }

        internal void Save(Window window) {
            Operation.Insert(User);
            window.Close();


        }
    }
}
