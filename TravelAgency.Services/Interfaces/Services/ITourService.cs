using TravelAgency.DTO;

namespace TravelAgency.Services.Interfaces.Services
{
    public interface ITourService
    {
        public void AddTour(Tour? tour);
        public void EditTour(Tour? tour);
        public void DeleteTour(int id);
        IEnumerable<Tour> GetToursByName(string? name = "");
        IEnumerable<Tour> GetAllTours();
        IEnumerable<Tour> GetInactiveTours();
        Tour? GetTour(int id);
    }
}
