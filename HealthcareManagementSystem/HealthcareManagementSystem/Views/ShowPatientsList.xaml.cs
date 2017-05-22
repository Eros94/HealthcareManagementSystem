using System.Linq;
using System.Windows;
using HealthcareManagementSystem.DAL;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for ShowPatientsList.xaml
    /// </summary>
    public partial class ShowPatientsList
    {
        public ShowPatientsList()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var typedWord = SearchPatientsBox.Text;
            var filter = FilterPatientsComboBox.Text;
            var query = PatientsDAO.GetPatientsQuery(typedWord, filter);
            if (query != null)
            {
                PatientsGrid.ItemsSource = query.ToList();
            }
            else
            {
                QueryPatientsResult.Content = "No result found!";
                PatientsGrid.ItemsSource = null;
            }
        }
    }
}