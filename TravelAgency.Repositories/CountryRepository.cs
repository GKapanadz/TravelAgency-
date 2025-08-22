using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repositories
{
    internal class CountryRepository : BaseRepository<Country> , ICountryRepository
    {
        public CountryRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {

        }
    }
}
