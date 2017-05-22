using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : MetroWindow
    {
        public AdminPanel()
        {
            InitializeComponent();
            var adminPanelViewModel = new AdminPanelViewModel();
            DataContext = adminPanelViewModel;
        }
    }
}