using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for UsersManagement.xaml
    /// </summary>
    public partial class UsersManagement : MetroWindow
    {
        public UsersManagement()
        {
            InitializeComponent();
            var usersManagementViewModel = new UsersManagementViewModel();
            DataContext = usersManagementViewModel;
        }
    }
}