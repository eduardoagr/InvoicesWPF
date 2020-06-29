using System.Windows;
using System.Windows.Input;

namespace Invoices.Dialogs {
    /// <summary>
    /// Interaction logic for InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window {
        public InputDialog() {
            InitializeComponent();
        }
        private void WindowCommandBar_MouseDown(object sender, MouseButtonEventArgs e) {

            DragMove();
        }
    }
}
