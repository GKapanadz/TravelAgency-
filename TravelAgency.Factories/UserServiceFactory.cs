using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Services;
using TravelAgency.Repositories;
using Microsoft.Data.SqlClient;
using TravelAgency.Services;

namespace TravelAgency.Factories
{
    public static class UserServiceFactory
    {
        public static IUserService Create()
        {
            IUnitOfWork unitOfWork = new UnitOfWork(new SqlConnection(ConfigurationManager.ConnectionString));

            return Create(unitOfWork);
        }

        public static IUserService Create(IUnitOfWork unitOfWork)
        {
            return new UserService(unitOfWork);
        }
    }
}
