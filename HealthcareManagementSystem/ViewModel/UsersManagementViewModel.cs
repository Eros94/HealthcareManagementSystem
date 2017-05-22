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
    internal class UsersManagementViewModel : ViewModelBase
    {
        private string _cin;
        private ObservableCollection<string> _cities;

        private string _city;

        private string _filterSearch;

        private string _firstname;

        private int _id;

        private string _lastname;

        private string _phoneNumber;

        private string _profession;

        private string _role;

        private string _searchWord;

        private DateTime _selectedDate;

        private User _selectedUser;

        private string _speciality;

        private bool _superUser;

        private ObservableCollection<User> _users;

        private int _yearsOfExp;

        public UsersManagementViewModel()
        {
            EditCommand = new RelayCommand(Edit);
            ToEditTabCommand = new RelayCommand(ToEditTab);
            GetListUsersCommand = new RelayCommand(GetListUsers);
            ToAddTabCommand = new RelayCommand(ToAddTab);
            RemoveCommand = new RelayCommand(Remove);
            ToAddAppointmentTabCommand = new RelayCommand(ToAddAppointmentTab);
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            Cities = CityDAO.GetCitiesQuery().ToObservableCollection();
        }


        public UsersManagementViewModel(User selectedUser)
        {
            EditCommand = new RelayCommand(Edit);
            ToEditTabCommand = new RelayCommand(ToEditTab);
            GetListUsersCommand = new RelayCommand(GetListUsers);
            ToAddTabCommand = new RelayCommand(ToAddTab);
            RemoveCommand = new RelayCommand(Remove);
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            Cities = CityDAO.GetCitiesQuery().ToObservableCollection();
            LoadData(selectedUser);
            SelectedUser = selectedUser;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("IdUser");
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

        public string CIN
        {
            get { return _cin; }
            set
            {
                _cin = value;
                RaisePropertyChanged("CIN");
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

        public ObservableCollection<string> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                RaisePropertyChanged("Cities");
            }
        }

        public string SearchWord
        {
            get { return _searchWord; }
            set
            {
                _searchWord = value;
                RaisePropertyChanged("SearchWord");
            }
        }

        public string FilterSearch
        {
            get { return _filterSearch; }
            set
            {
                _filterSearch = value;
                RaisePropertyChanged("FilterSearch");
            }
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                RaisePropertyChanged("Users");
            }
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                RaisePropertyChanged("SelectedUser");
            }
        }

        public ICommand ToAddAppointmentTabCommand { get; set; }

        public ICommand ToAddTabCommand { get; set; }

        public ICommand ToEditTabCommand { get; set; }

        public ICommand GetListUsersCommand { get; set; }

        public ICommand EditCommand { get; set; }

        public ICommand RemoveCommand { get; set; }

        public ICommand ToUsersManagementTabCommand { get; set; }

        public void LoadData(User selectedUser)
        {
            Id = selectedUser.IdUser;
            Firstname = selectedUser.Fisrtname;
            Lastname = selectedUser.Lastname;
            CIN = selectedUser.CIN;
            SuperUser = selectedUser.IsSuperUser;
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

        public void ToAddTab()
        {
            var addUserWindow = new AddUser();
            var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            addUserWindow.Show();
            activeWindow.Close();
        }

        private void ToEditTab()
        {
            if (SelectedUser != null)
            {
                var editUserWindow = new EditUser(SelectedUser);
                var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
                editUserWindow.Show();
                activeWindow.Close();
            }
            else
            {
                MessageBox.Show("Please select a user");
            }
        }

        public void ToAddAppointmentTab()
        {
            if (SelectedUser != null)
            {
                var addAppointmentWindow = new AddAppointment(SelectedUser.IdUser);
                var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
                addAppointmentWindow.Show();
                activeWindow.Close();
            }
            else
            {
                MessageBox.Show("Please select a user");
            }
        }


        public void GetListUsers()
        {
            var query = UsersDAO.GetUsersQuery(SearchWord, FilterSearch);
            if (query != null) Users = query.ToObservableCollection();
        }

        private void Edit()
        {
            var updatedUser = new User(Id, Firstname, Lastname, CIN, SelectedDate, SuperUser, PhoneNumber, Role, City);
            UsersDAO.UpdateUser(updatedUser);
            MessageBox.Show("User Updated!");
        }

        private void Remove()
        {
            if (SelectedUser != null)
            {
                UsersDAO.RemoveUser(SelectedUser);
                Users.Remove(SelectedUser);
                MessageBox.Show("User Removed!");
            }
            else
            {
                MessageBox.Show("Please select a user to remove");
            }
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