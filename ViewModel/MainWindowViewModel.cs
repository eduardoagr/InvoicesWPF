
using Invoices.DatabaseHelpers;
using Invoices.Dialogs;
using Invoices.Model;
using Invoices.ViewModel.Commands;

using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Invoices.ViewModel {
    class MainWindowViewModel {

        int x = 0;

        public List<User> Users { get; set; }
        public ICommand OpenDialogCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public MainWindowViewModel() {

            Users = new List<User>();
            OpenDialogCommand = new OpenDialogCommand(this);
            CloseCommand = new CloseCommand(this);

        }

        internal void OpenDialog() {

            var dialog = new InputDialog();
            dialog.ShowDialog();
            Users = Operation.Read();
        }

        internal void Close(object obj) {
            Window win = obj as Window;
            win.Close();
        }
    }
}
