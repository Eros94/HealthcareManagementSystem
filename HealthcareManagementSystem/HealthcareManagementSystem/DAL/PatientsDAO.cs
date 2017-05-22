using System;
using System.Linq;

namespace HealthcareManagementSystem.DAL
{
    internal class PatientsDAO
    {
        public static void PersistPatient(User user)
        {
            DataContext.Context.Users.Add(user);
            DataContext.Context.SaveChanges();
        }

        public static IQueryable<User> GetPatientsQuery(string typedWord, string filter)
        {
            IQueryable<User> query = null;
            if (typedWord != null)
                switch (filter)
                {
                    case "Firstname":
                        query =
                            DataContext.Context.Users.OfType<Patient>().Where(patient => patient.Fisrtname == typedWord);
                        break;
                    case "Lastname":
                        query =
                            DataContext.Context.Users.OfType<Patient>().Where(patient => patient.Lastname == typedWord);
                        break;
                    case "Phone Number":
                        query =
                            DataContext.Context.Users.OfType<Patient>()
                                .Where(patient => patient.PhoneNumber == typedWord);
                        break;
                    case "Role":
                        query =
                            DataContext.Context.Users.OfType<Patient>().Where(patient => patient.Role == typedWord);
                        break;
                    case "Date Of Birth":
                        DateTime typedDate;
                        if (DateTime.TryParse(typedWord, out typedDate))
                            query =
                                DataContext.Context.Users.OfType<Patient>()
                                    .Where(patient => patient.DateOfBirth == typedDate);
                        break;
                    case "City":
                        query =
                            DataContext.Context.Users.OfType<Patient>()
                                .Where(patient => patient.City.CityName == typedWord);
                        break;
                }
            return query;
        }
    }
}