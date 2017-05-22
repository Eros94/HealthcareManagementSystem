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
    }
}