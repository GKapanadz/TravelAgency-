using Dapper;
using System.Data;
using System.Diagnostics;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repositories
{
    internal class TourRepository : BaseRepository<Tour> , ITourRepository
    {
        public TourRepository(IDbConnection connection, Func<IDbTransaction> getTrasnaction) : base(connection, getTrasnaction)
        {

        }
        
    }
}
