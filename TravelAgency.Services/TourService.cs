using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgency.Services
{
    public sealed class TourService : ITourService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TourService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public void AddTour(Tour? tour)
        {
            ArgumentNullException.ThrowIfNull(tour);
            tour.TourID = (int)_unitOfWork.TourRepository.Insert(tour);
        }

        public void EditTour(Tour? tour)
        {
            ArgumentNullException.ThrowIfNull(tour);
            _unitOfWork.TourRepository.Update(tour);
        }

        public void DeleteTour(int id)
        {
            _unitOfWork.TourRepository.Delete(id);
        }

        public Tour? GetTour(int id)
        {
            return _unitOfWork.TourRepository.Get(id);
        }

        public IEnumerable<Tour> GetToursByName(string? name)
        {
            name = (name ?? "").ToLower();

            return _unitOfWork.TourRepository.Query(x =>
                x.IsActive &&
                x.Name.ToLower().Contains(name)
            );
        }

        public IEnumerable<Tour> GetAllTours()
        {
             return _unitOfWork.TourRepository.Query(x => x.Name.StartsWith(""));
        }

        public IEnumerable<Tour> GetInactiveTours()
        {
             return _unitOfWork.TourRepository.Query(x => !x.IsActive);
        }
    }
}
