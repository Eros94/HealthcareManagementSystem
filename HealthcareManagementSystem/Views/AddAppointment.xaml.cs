using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for AddAppointment.xaml
    /// </summary>
    public partial class AddAppointment : MetroWindow
    {
        public AddAppointment(int id)
        {
            InitializeComponent();
            var addAppointmentViewModel = new AddAppointmentViewModel(id);
            DataContext = addAppointmentViewModel;
        }
    }
}