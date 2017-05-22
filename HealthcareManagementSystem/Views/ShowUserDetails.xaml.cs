using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for ShowUserDetails.xaml
    /// </summary>
    public partial class ShowUserDetails : MetroWindow
    {
        public ShowUserDetails(User user)
        {
            InitializeComponent();
            var showUserDetailsViewModel = new ShowUserDetailsViewModel(user);
            DataContext = showUserDetailsViewModel;
        }
    }
}