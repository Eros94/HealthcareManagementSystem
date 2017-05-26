using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using HealthcareManagementSystem.DAL;
using HealthcareManagementSystem.ViewModel;
using MahApps.Metro.Controls;
using TimelineLibrary;

namespace HealthcareManagementSystem.Views
{
    /// <summary>
    ///     Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : MetroWindow
    {
        public AdminPanel()
        {
            InitializeComponent();
            var adminPanelViewModel = new AdminPanelViewModel();
            DataContext = adminPanelViewModel;
            List<TimelineEvent> listOfTodaysAppointments = AppointmentDAO.GetTodaysAppointments();
            Timeline.ResetEvents(listOfTodaysAppointments);
        }
    }
}