using System;

namespace HealthcareManagementSystem.DAL
{
    internal class AppointmentDAO
    {
        public static void AddAppointment(string cost, DateTime dateTime, string natureOfAct, int idPatient)
        {
            var patientDb = UsersDAO.GetPatientById(idPatient);
            var appointment = new Appointment(cost, dateTime, natureOfAct, patientDb);
            DataContext.Context.Appointments.Add(appointment);
            DataContext.Context.SaveChanges();
        }
    }
}