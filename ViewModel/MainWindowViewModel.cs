
using Invoices.DatabaseHelpers;
using Invoices.Dialogs;
using Invoices.Model;
using Invoices.ViewModel.Commands;

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Invoices.ViewModel {
    class MainWindowViewModel {

        public User SelectedUser { get; set; }

        public ObservableCollection<User> Users { get; set; }
        public ICommand OpenDialogCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public MainWindowViewModel() {

            Users = new ObservableCollection<User>();
            OpenDialogCommand = new OpenDialogCommand(this);
            CloseCommand = new CloseCommand(this);
            Users = Operation.Read();

        }

        internal void OpenDialog(Window win) {

            var dialog = new InputDialog();
            dialog.Top = win.Top + 40;
            dialog.Left = win.Left - 230;
            Debug.WriteLine(dialog.Left);
            dialog.ShowDialog();

            Users = Operation.Read();
        }

        internal void Close(object obj) {
            Window win = obj as Window;
            win.Close();
        }
    }
}
