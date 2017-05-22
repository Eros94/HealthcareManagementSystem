using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : MetroWindow
    {
        public AddUser()
        {
            InitializeComponent();
            var userManagementViewModelViewModel = new UsersManagementViewModel();
            DataContext = userManagementViewModelViewModel;
        }
    }
}