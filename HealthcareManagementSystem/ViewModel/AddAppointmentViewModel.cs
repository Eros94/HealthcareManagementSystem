using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HealthcareManagementSystem.DAL;
using HealthcareManagementSystem.Views;

namespace HealthcareManagementSystem.ViewModel
{
    internal class AddAppointmentViewModel : ViewModelBase
    {
        private string _cost;

        private DateTime _dateOfAppointment;
        private int _id;

        private string _natureOfAct;

        private DateTime _timeOfAppointment;

        public AddAppointmentViewModel(int id)
        {
            AddAppointmentCommand = new RelayCommand(AddAppointment);
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            DateOfAppointment = DateTime.Now;
            Id = id;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string Cost
        {
            get { return _cost; }
            set
            {
                _cost = value;
                RaisePropertyChanged("Cost");
            }
        }

        public DateTime TimeOfAppointment
        {
            get { return _timeOfAppointment; }
            set
            {
                _timeOfAppointment = value;
                RaisePropertyChanged("TimeOfAppointment");
            }
        }

        public DateTime DateOfAppointment
        {
            get { return _dateOfAppointment; }
            set
            {
                _dateOfAppointment = value;
                RaisePropertyChanged("DateOfAppointment");
            }
        }

        public string NatureOfAct
        {
            get { return _natureOfAct; }
            set
            {
                _natureOfAct = value;
                RaisePropertyChanged("NatureOfAct");
            }
        }

        public ICommand AddAppointmentCommand { get; set; }
        public ICommand ToUsersManagementTabCommand { get; set; }

        public void AddAppointment()
        {
            var dateTime =
                DateTime.ParseExact(DateOfAppointment.ToShortDateString() + " " + TimeOfAppointment.ToLongTimeString(),
                    "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            AppointmentDAO.AddAppointment(Cost, dateTime, NatureOfAct, Id);
            MessageBox.Show("Appointment added!");
        }

        public void ToUsersManagementTab()
        {
            var mainWindow = new UsersManagement();
            var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            mainWindow.Show();
            activeWindow.Close();
        }
    }
}