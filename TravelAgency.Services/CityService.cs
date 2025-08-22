using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgency.Services
{
    public sealed class CityService : ICityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public void AddCity(City? city)
        {
            ArgumentNullException.ThrowIfNull(city);
            city.CityID = (int)_unitOfWork.CityRepository.Insert(city);
        }

        public void EditCity(City? city)
        {
            ArgumentNullException.ThrowIfNull(city);
            _unitOfWork.CityRepository.Update(city);
        }

        public void DeleteCity(int id)
        {
            _unitOfWork.CityRepository.Delete(id);
        }

        public City? GetCity(int id)
        {
            return _unitOfWork.CityRepository.Get(id);
        }

        public IEnumerable<City> GetCityByName(string? name = "")
        {
            name = (name ?? "").ToLower();
            return _unitOfWork.CityRepository.Query(x =>
            x.IsActive && x.Name.ToLower().Contains(name));
        }

        public IEnumerable<City> GetAllCities()
        {
            return _unitOfWork.CityRepository.Query(x => x.Name.StartsWith(""));
        }

        public IEnumerable<City> GetInactiveCity()
        {
            return _unitOfWork.CityRepository.Query(x => !x.IsActive);
        }

    }
}
