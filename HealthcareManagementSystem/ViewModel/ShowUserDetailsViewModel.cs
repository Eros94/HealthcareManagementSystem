using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace HealthcareManagementSystem.ViewModel
{
    internal class ShowUserDetailsViewModel : ViewModelBase
    {
        private string _cin;

        private string _city;

        private string _firstname;

        private string _lastname;

        private string _phoneNumber;

        private string _profession;

        private string _role;

        private DateTime _selectedDate;

        private string _speciality;

        private int _yearsOfExp;

        public ShowUserDetailsViewModel(User user)
        {
            LoadData(user);
            LogoutCommand = new RelayCommand(Logout);
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                RaisePropertyChanged("Firstname");
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                RaisePropertyChanged("Lastname");
            }
        }

        public string CIN
        {
            get { return _cin; }
            set
            {
                _cin = value;
                RaisePropertyChanged("CIN");
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged("PhoneNumber");
            }
        }

        public string Role
        {
            get { return _role; }
            set
            {
                _role = value;
                RaisePropertyChanged("Role");
            }
        }

        public string Profession
        {
            get { return _profession; }
            set
            {
                _profession = value;
                RaisePropertyChanged("Profession");
            }
        }

        public string Speciality
        {
            get { return _speciality; }
            set
            {
                _speciality = value;
                RaisePropertyChanged("Speciality");
            }
        }

        public int YearsOfExp
        {
            get { return _yearsOfExp; }
            set
            {
                _yearsOfExp = value;
                RaisePropertyChanged("YearsOfExp");
            }
        }

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                RaisePropertyChanged("SelectedDate");
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                RaisePropertyChanged("City");
            }
        }

        public ICommand LogoutCommand { get; set; }

        public void Logout()
        {
            var authentificationWindow = new Authentification();
            var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            authentificationWindow.Show();
            activeWindow.Close();
        }

        public void LoadData(User selectedUser)
        {
            Firstname = selectedUser.Fisrtname;
            Lastname = selectedUser.Lastname;
            CIN = selectedUser.CIN;
            PhoneNumber = selectedUser.PhoneNumber;
            Role = selectedUser.Role;
            SelectedDate = selectedUser.DateOfBirth;
            City = selectedUser.City.CityName;
            var role = selectedUser.Role;
            if (role == "Patient")
            {
                var patient = (Patient) selectedUser;
                Profession = patient.Profession;
            }
            else if (role == "Doctor")
            {
                var doctor = (Doctor) selectedUser;
                Speciality = doctor.Speciality;
            }
            else if (role == "Secretary")
            {
                var secretary = (Secretary) selectedUser;
                YearsOfExp = secretary.ExperienceYears;
            }
        }
    }
}