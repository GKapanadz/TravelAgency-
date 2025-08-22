using TravelAgency.DTO;

namespace TravelAgency.Services.Interfaces.Services
{
    public interface IUserService
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int id);
        IEnumerable<User> GetUsersByName(string? username = "");
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        int LoginUser(string username, string password);
    }
}
