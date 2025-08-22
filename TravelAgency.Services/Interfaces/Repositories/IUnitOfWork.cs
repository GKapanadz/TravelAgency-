
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public void BeginTransaction();
        public void Commit();
        public void RollBack();

        ICityRepository CityRepository { get; }
        ICountryRepository CountryRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IHotelRepository HotelRepository { get; }
        IPositionRepository PositionRepository { get; }
        ITouristRepository TouristRepostory { get; }
        ITourRepository TourRepository { get; }
        ITourStopRepository TourStopRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
