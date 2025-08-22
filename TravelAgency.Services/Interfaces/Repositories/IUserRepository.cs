using TravelAgency.DTO;

namespace TravelAgency.Services.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        int LoginUser(string username, string password);
    }
}
