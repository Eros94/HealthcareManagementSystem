using System;
using System.Collections.Generic;
using System.Linq;
using TimelineLibrary;

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

        public static List<TimelineEvent> GetTodaysAppointments()
        {
            List<TimelineEvent> listOfTodaysAppointments = new List<TimelineEvent>();
            DateTime today = DateTime.Today.Date;
            List<Appointment> appointments = DataContext.Context.Appointments.Where(a => System.Data.Entity.DbFunctions.TruncateTime(a.DateAndTime) == today).ToList();
            foreach (var appointment in appointments)
            {
                TimelineEvent appointmentEvent = new TimelineEvent();

                appointmentEvent.StartDate = appointment.DateAndTime;

                string description = "Fullname: " + appointment.Patient.Fisrtname + " " + appointment.Patient.Lastname + "\n" +
                                     "Cost: " + appointment.Cost + "\n" +
                                     "Type: " + appointment.NatureOfAct;
                appointmentEvent.Description = description;

                var color = appointment.DateAndTime.TimeOfDay > DateTime.Now.TimeOfDay ? "Blue" : "Red";
                appointmentEvent.EventColor = color;

                listOfTodaysAppointments.Add(appointmentEvent);
            }
            return listOfTodaysAppointments;
        }
    }
}