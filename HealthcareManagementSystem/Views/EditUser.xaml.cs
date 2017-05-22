using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    public partial class EditUser : MetroWindow
    {
        public EditUser(User selectedUser)
        {
            InitializeComponent();
            var userManagementViewModelViewModel = new UsersManagementViewModel(selectedUser);
            DataContext = userManagementViewModelViewModel;
        }
    }
}