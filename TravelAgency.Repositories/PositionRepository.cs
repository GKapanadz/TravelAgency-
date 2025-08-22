using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repositories
{
    internal class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {
        }
    }
}
