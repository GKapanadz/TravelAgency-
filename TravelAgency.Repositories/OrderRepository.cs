using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repositories
{
    internal class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {

        }
    }
}
