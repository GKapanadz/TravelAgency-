using System.Data;
using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly IDbConnection _connection;
        private IDbTransaction? _transaction;
        private bool _disposed;

        private readonly Lazy<ICityRepository> _cityRepository;
        private readonly Lazy<ICountryRepository> _countryRepository;
        private readonly Lazy<IHotelRepository> _hotelRepository;
        private readonly Lazy<ITouristRepository> _touristRepository;
        private readonly Lazy<ITourRepository> _tourRepository;
        private readonly Lazy<ITourStopRepository> _tourStopRepository;
        private readonly Lazy<IPositionRepository> _positionRepository;
        private readonly Lazy<IEmployeeRepository> _employeeReposiotry;
        private readonly Lazy<IUserRepository> _userRepository;      

        public UnitOfWork(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
            _cityRepository = new Lazy<ICityRepository>(() => new CityRepository(_connection, GetTransaction));
            _countryRepository = new Lazy<ICountryRepository>(() => new CountryRepository(_connection, GetTransaction));
            _hotelRepository = new Lazy<IHotelRepository>(() => new HotelRepository(_connection, GetTransaction));
            _touristRepository = new Lazy<ITouristRepository>(() => new TouristRepository(_connection, GetTransaction));
            _tourRepository = new Lazy<ITourRepository>(() => new TourRepository(_connection, GetTransaction));
            _tourStopRepository = new Lazy<ITourStopRepository>(() => new TourStopRepository(_connection, GetTransaction));
            _positionRepository = new Lazy<IPositionRepository>(() => new PositionRepository(_connection, GetTransaction));
            _employeeReposiotry = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_connection, GetTransaction));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_connection, GetTransaction));
        }

        public void BeginTransaction()
        {
            if (_transaction != null)
                throw new ArgumentException("Transaction is already started");

            _connection.BeginTransaction();
        }

        public void Commit()
        {
            if (_transaction == null)
                throw new ArgumentException("Transaction is not started");

            _transaction?.Commit();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void RollBack()
        {
            if (_transaction == null)
                throw new ArgumentException("Transaction is not started");

            _transaction?.Rollback();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void Dispose()
        {
            if(!_disposed)
            {
                _transaction?.Dispose();
                _disposed = true;
            }
        }

        public ICityRepository CityRepository => _cityRepository.Value;
        public ICountryRepository CountryRepository => _countryRepository.Value;
        public IHotelRepository HotelRepository => _hotelRepository.Value;
        public ITouristRepository TouristRepostory => _touristRepository.Value;
        public ITourRepository TourRepository => _tourRepository.Value;
        public ITourStopRepository TourStopRepository => _tourStopRepository.Value;
        public IPositionRepository PositionRepository => _positionRepository.Value;
        public IEmployeeRepository EmployeeRepository => _employeeReposiotry.Value;
        public IUserRepository UserRepository => _userRepository.Value;
        public IDbTransaction? GetTransaction() => _transaction;
    }
}
