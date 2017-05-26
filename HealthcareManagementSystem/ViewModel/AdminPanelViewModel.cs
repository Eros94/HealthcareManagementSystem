using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HealthcareManagementSystem.Views;

namespace HealthcareManagementSystem.ViewModel
{
    internal class AdminPanelViewModel : ViewModelBase
    {
        public AdminPanelViewModel()
        {
            ToUsersManagementTabCommand = new RelayCommand(ToUsersManagementTab);
            LogoutCommand = new RelayCommand(Logout);
            WelcomeMessage = "Welcome! Today is " + DateTime.Today.ToShortDateString() + "\n" 
                                + "Time: " + DateTime.Now.ToShortTimeString();
        }

        private string _welcomeMessage;

        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set
            {
                _welcomeMessage = value;
                RaisePropertyChanged("WelcomeMessage");
            }
        }

        public ICommand ToUsersManagementTabCommand { get; set; }
        
        public void ToUsersManagementTab()
        {
            var mainWindow = new UsersManagement();
            var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            mainWindow.Show();
            activeWindow.Close();
        }

        public ICommand LogoutCommand { get; set; }

        public void Logout()
        {
            var authentificationWindow = new Authentification();
            var activeWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            authentificationWindow.Show();
            activeWindow.Close();
        }

    }
}