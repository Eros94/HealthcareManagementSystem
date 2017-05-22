using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HealthcareManagementSystem.DAL;
using HealthcareManagementSystem.Utilities;
using HealthcareManagementSystem.Views;

namespace HealthcareManagementSystem.ViewModel
{
    internal class AddUserViewModel : ViewModelBase
    {
        private string _cin;
        private ObservableCollection<string> _cities;

        private string _city;

        private string _firstname;

        private string _lastname;

        private string _password;

        private string _phoneNumber;

        private string _profession;

        private string _role;

        private DateTime _selectedDate;

        private string _speciality;

        private string _superPassword;

        private bool _superUser;

        private int _yearsOfExp;

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser);
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            SelectedDate = new DateTime(1970, 1, 1);
            Cities = CityDAO.GetCitiesQuery().ToObservableCollection();
        }

        public ObservableCollection<string> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                RaisePropertyChanged("Cities");
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

        public string CIN
        {
            get { return _cin; }
            set
            {
                _cin = value;
                RaisePropertyChanged("CIN");
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

        public string Profession
        {
            get { return _profession; }
            set
            {
                _profession = value;
                RaisePropertyChanged("Profession");
            }
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

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged("Password");
            }
        }

        public string SuperPassword
        {
            get { return _superPassword; }
            set
            {
                _superPassword = value;
                RaisePropertyChanged("SuperPassword");
            }
        }

        public bool SuperUser
        {
            get { return _superUser; }
            set
            {
                _superUser = value;
                RaisePropertyChanged("SuperUser");
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

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                RaisePropertyChanged("SelectedDate");
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

        public string Speciality
        {
            get { return _speciality; }
            set
            {
                _speciality = value;
                RaisePropertyChanged("Speciality");
            }
        }

        public ICommand AddUserCommand { get; set; }
        public ICommand ToUsersManagementTabCommand { get; set; }

        public void AddUser()
        {
            if (Role == "Doctor")
            {
                var user = new Doctor(Firstname, Lastname, CIN, SelectedDate, Password, SuperUser, PhoneNumber, Role,
                    City);
                DataContext.Context.Users.Add(user);
                user.Speciality = Speciality;
            }
            else if (Role == "Secretary")
            {
                var user = new Secretary(Firstname, Lastname, CIN, SelectedDate, Password, SuperUser, PhoneNumber, Role,
                    City);
                DataContext.Context.Users.Add(user);
                user.ExperienceYears = YearsOfExp;
            }
            else if (Role == "Patient")
            {
                var user = new Patient(Firstname, Lastname, CIN, SelectedDate, Password, SuperUser, PhoneNumber, Role,
                    City);
                DataContext.Context.Users.Add(user);
                user.Profession = Profession;
                user.LastVisit = DateTime.Today.ToShortDateString();
            }
            else
            {
                var user = new SuperUser(Firstname, Lastname, CIN, SelectedDate, Password, SuperUser, PhoneNumber, Role,
                    City);
                DataContext.Context.Users.Add(user);
                user.SuperPassword = SuperPassword;
            }
            DataContext.Context.SaveChanges();

            MessageBox.Show("User Added!");
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