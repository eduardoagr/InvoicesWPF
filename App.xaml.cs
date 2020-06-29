using System.Windows;

namespace Invoices {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        public App() {
            const string KEY = "Mjc2NjI1QDMxMzgyZTMxMmUzME5aOWp3ZkpSSUZIZ0R6YlNxZGJWakdUNVdsTlNadktUMnlTRjlWelJ0R2c9";
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(KEY);
        }
    }
}