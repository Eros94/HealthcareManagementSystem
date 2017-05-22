using System.Linq;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HealthcareManagementSystem.DAL;
using HealthcareManagementSystem.Utilities;
using HealthcareManagementSystem.Views;

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
            var hashedPassword = PasswordUtilities.ComputeHash(Password, new MD5CryptoServiceProvider());
            if (dbUser != null) // USER FOUND
                if (dbUser.IsSuperUser) // SUPERUSER
                {
                    var superUser = (SuperUser) dbUser;
                    if (superUser.HashedPassword == hashedPassword) // SUPERUSER WANTS TO ACCESS ADMIN PANEL
                    {
                        var usersManagementWindow = new UsersManagement();
                        var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
                        usersManagementWindow.Show();
                        activeWindow.Close();
                    }
                } // USER
                else
                {
                    if (dbUser.HashedPassword == hashedPassword)
                    {
                        var usersManagementWindow = new ShowUserDetails(dbUser);
                        var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
                        usersManagementWindow.Show();
                        activeWindow.Close();
                        return;
                    }
                    var listSuperPasswords = UsersDAO.GetSuperPasswords();
                    foreach (var pass in listSuperPasswords)
                        if (pass == hashedPassword) // SUPERUSER WANTS TO ACCESS USER PANEL
                        {
                            var usersManagementWindow = new ShowUserDetails(dbUser);
                            var activeWindow =
                                Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
                            usersManagementWindow.Show();
                            activeWindow.Close();
                            return;
                        }
                }
            else
                MessageBox.Show("Wrong login or password!");
        }
    }
}