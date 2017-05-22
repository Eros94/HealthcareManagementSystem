using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Authentification : MetroWindow
    {
        public Authentification()
        {
            InitializeComponent();
            var authentificationViewModel = new AuthentificationViewModel();
            DataContext = authentificationViewModel;
        }
    }
}