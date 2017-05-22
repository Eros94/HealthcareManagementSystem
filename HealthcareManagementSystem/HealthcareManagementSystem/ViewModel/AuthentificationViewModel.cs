using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HealthcareManagementSystem.DAL;

namespace HealthcareManagementSystem.ViewModel
{
    internal class AuthentificationViewModel : ViewModelBase
    {
        private string _login;

        private string _password;

        public AuthentificationViewModel()
        {
            AuthCommand = new RelayCommand(Auth);
            ClearCommand = new RelayCommand(Clear);
        }

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                RaisePropertyChanged("Login");
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

        public ICommand ClearCommand { get; set; }

        public ICommand AuthCommand { get; set; }

        public void Clear()
        {
            Login = null;
            Password = null;
        }

        public void Auth()
        {
            var dbUser = UsersDAO.GetUserByLogin(Login);
            if (dbUser != null) // USER FOUND
                if (dbUser.IsSuperUser) // SUPERUSER
                {
                    var superUser = (SuperUser) dbUser;
                    if (superUser.SuperHashedPassword == Password) //SUPERUSER WANTS TO ACCESS USER PANEL
                        MessageBox.Show("SUPERUSER WANTS TO ACCESS USER PANEL");
                    else // SUPERUSER WANTS TO ACCESS ADMIN PANEL
                        MessageBox.Show("SUPERUSER WANTS TO ACCESS ADMIN PANEL");
                } // USER
                else
                {
                    MessageBox.Show("USER WANTS TO ACCESS USER PANEL");
                }
            else
                MessageBox.Show("Wrong login or password!");
        }
    }
}