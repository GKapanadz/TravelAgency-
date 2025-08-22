using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repositories
{
    internal class HotelRepository : BaseRepository<Hotel> , IHotelRepository
    {
        public HotelRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {

        }
    }
}
