using TravelAgency.DTO;

namespace TravelAgency.Services.Interfaces.Services
{
    public interface ICityService
    {
        public void AddCity(City? city);
        public void EditCity(City? city);
        public void DeleteCity(int id);
        IEnumerable<City> GetCityByName(string? name = "");
        IEnumerable<City> GetAllCities();
        IEnumerable<City> GetInactiveCity();
        City? GetCity(int id);
    }
}
