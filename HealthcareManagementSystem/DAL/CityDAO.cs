using System.Linq;

namespace HealthcareManagementSystem.DAL
{
    public class CityDAO
    {
        public static City GetCityByName(string cityName)
        {
            var city = DataContext.Context.Cities.FirstOrDefault(c => c.CityName == cityName);
            return city;
        }

        public static IQueryable<string> GetCitiesQuery()
        {
            var cities = DataContext.Context.Cities.Select(c => c.CityName);
            return cities;
        }
    }
}