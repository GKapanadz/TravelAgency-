using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repositories
{
    internal class TourStopRepository : BaseRepository<TourStop>, ITourStopRepository
    {
        public TourStopRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {

        }
    }
}
