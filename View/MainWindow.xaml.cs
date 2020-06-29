using Invoices.DatabaseHelpers;

using System.Windows;
using System.Windows.Input;

namespace Invoices {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Operation.Read();
        }

        private void WindowCommandBar_MouseDown(object sender, MouseButtonEventArgs e) {

            DragMove();
        }
    }
}
