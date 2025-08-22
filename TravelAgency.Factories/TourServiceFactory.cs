using Microsoft.Data.SqlClient;
using TravelAgency.Repositories;
using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Services;
using TravelAgency.Services;

namespace TravelAgency.Factories
{
    public static class TourServiceFactory
    {
        public static ITourService Create()
        {
            IUnitOfWork unitOfWork = new UnitOfWork(new SqlConnection(ConfigurationManager.ConnectionString));
            return Create(unitOfWork);
        }

        public static ITourService Create(IUnitOfWork unitOfWork)
        {
            return new TourService(unitOfWork);
        }
    }
}
