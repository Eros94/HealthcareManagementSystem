using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HealthcareManagementSystem.DAL
{
    internal class UsersDAO
    {
        public static IQueryable<User> GetUsersQuery(string typedWord, string filter)
        {
            IQueryable<User> query = null;
            if (typedWord != null)
                switch (filter)
                {
                    case "Firstname":
                        query =
                            DataContext.Context.Users.Where(user => user.Fisrtname == typedWord);
                        break;
                    case "Lastname":
                        query =
                            DataContext.Context.Users.Where(user => user.Lastname == typedWord);
                        break;
                    case "Phone Number":
                        query =
                            DataContext.Context.Users.Where(user => user.PhoneNumber == typedWord);
                        break;
                    case "Role":
                        query =
                            DataContext.Context.Users.Where(user => user.Role == typedWord);
                        break;
                    case "Date Of Birth":
                        DateTime typedDate;
                        if (DateTime.TryParse(typedWord, out typedDate))
                            query =
                                DataContext.Context.Users.Where(user => user.DateOfBirth == typedDate);
                        break;
                    case "City":
                        query =
                            DataContext.Context.Users.Where(user => user.City.CityName == typedWord);
                        break;
                }
            return query;
        }

        public static void UpdateUser(User updatedUser)
        {
            var dbUser = GetUserById(updatedUser.IdUser);
            DataContext.Context.Users.Attach(dbUser);

            dbUser.IdUser = updatedUser.IdUser;
            dbUser.Fisrtname = updatedUser.Fisrtname;
            dbUser.Lastname = updatedUser.Lastname;
            dbUser.CIN = updatedUser.CIN;
            dbUser.DateOfBirth = updatedUser.DateOfBirth;
            dbUser.IsSuperUser = updatedUser.IsSuperUser;
            dbUser.PhoneNumber = updatedUser.PhoneNumber;
            dbUser.Role = updatedUser.Role;
            dbUser.City = updatedUser.City;

            DataContext.Context.SaveChanges();
        }

        public static User GetUserById(int id)
        {
            var user = DataContext.Context.Users.FirstOrDefault(u => u.IdUser == id);
            return user;
        }

        public static Patient GetPatientById(int id)
        {
            var user = DataContext.Context.Users.OfType<Patient>().FirstOrDefault(u => u.IdUser == id);
            return user;
        }

        public static void RemoveUser(User selectedUser)
        {
            DataContext.Context.Users.Attach(selectedUser);
            DataContext.Context.Users.Remove(selectedUser);
            DataContext.Context.SaveChanges();
        }

        public static User GetUserByLogin(string login)
        {
            var dbUser = DataContext.Context.Users.OfType<User>().FirstOrDefault(u => u.CIN == login);
            return dbUser;
        }

        public static List<string> GetSuperPasswords()
        {
            var listSuperPasswords =
                DataContext.Context.Users.OfType<SuperUser>().Select(u => u.SuperHashedPassword).ToList();
            return listSuperPasswords;
        }

        public static DateTime GetLastVisit(int id)
        {
            var listOfAppointments =
                DataContext.Context.Appointments.Where(u => u.Patient.IdUser == id)
                    .Select(a => a.DateAndTime)
                    .ToList();
            return listOfAppointments.Max();
        }
    }
}