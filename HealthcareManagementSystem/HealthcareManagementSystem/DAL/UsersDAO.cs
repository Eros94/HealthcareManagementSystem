using System;
using System.Linq;

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

            dbUser.Fisrtname = updatedUser.Fisrtname;
            dbUser.Lastname = updatedUser.Lastname;
            dbUser.DateOfBirth = updatedUser.DateOfBirth;
            dbUser.Password = updatedUser.HashedPassword;
            dbUser.IsSuperUser = updatedUser.IsSuperUser;
            dbUser.City = updatedUser.City;
            dbUser.PhoneNumber = updatedUser.PhoneNumber;
            dbUser.Role = updatedUser.Role;

            DataContext.Context.SaveChanges();
        }

        private static User GetUserById(int id)
        {
            var user = DataContext.Context.Users.FirstOrDefault(u => u.IdUser == id);
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
    }
}