using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repositories
{
    internal class CityRepository : BaseRepository<City> , ICityRepository
    {
        public CityRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {

        }
    }
}
