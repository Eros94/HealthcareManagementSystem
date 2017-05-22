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

        private string _city;

        private string _filterSearch;

        private string _firstname;

        private int _id;

        private string _lastname;

        private string _password;

        private string _phoneNumber;

        private string _profession;

        private string _role;

        private string _searchWord;

        private DateTime _selectedDate;

        private User _selectedUser;

        private string _speciality;

        private string _superPassword;

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
            AddUserCommand = new RelayCommand(AddUser);
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            SelectedDate = new DateTime(1970, 1, 1);
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

        public string Role
        {
            get { return _role; }
            set
            {
                _role = value;
                RaisePropertyChanged("Role");
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

        public string Profession
        {
            get { return _profession; }
            set
            {
                _profession = value;
                RaisePropertyChanged("Profession");
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

        public ICommand ToAddTabCommand { get; set; }

        public ICommand AddUserCommand { get; set; }

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
            SuperUser = selectedUser.IsSuperUser;
            PhoneNumber = selectedUser.PhoneNumber;
            Role = selectedUser.Role;
            SelectedDate = selectedUser.DateOfBirth;
            City = selectedUser.City.CityName;
        }

        public void ToAddTab()
        {
            var addUserWindow = new AddUser();
            addUserWindow.Show();
            Application.Current.MainWindow.Close();
        }

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
            DataContext.Context.SaveChanges();

            MessageBox.Show("User Added!");
        }

        private void ToEditTab()
        {
            if (SelectedUser != null)
            {
                var editUserWindow = new EditUser(SelectedUser);
                editUserWindow.Show();
                Application.Current.MainWindow.Close();
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
            var updatedUser = new User(Id, Firstname, Lastname, CIN, SelectedDate, Password, SuperUser, PhoneNumber,
                Role, City);
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