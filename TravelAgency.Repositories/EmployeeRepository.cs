using System.Data;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repositories
{
    internal class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbConnection connection, Func<IDbTransaction> getTransaction) : base(connection, getTransaction)
        {
        }
    }
}
