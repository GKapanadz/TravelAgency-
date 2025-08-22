using TravelAgency.DTO;
using TravelAgency.Services.Exceptions;
using TravelAgency.Services.Interfaces;
using TravelAgency.Services.Interfaces.Services;

namespace TravelAgency.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public void AddUser(User user)
        {
            ArgumentNullException.ThrowIfNull(user);
            user.UserID = (int)_unitOfWork.UserRepository.Insert(user);
        }

        public void DeleteUser(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
        }

        public void EditUser(User user)
        {
            ArgumentNullException.ThrowIfNull(user);
            _unitOfWork.UserRepository.Update(user);
        }

        public User? GetUser(int id)
        {
            return _unitOfWork.UserRepository.Get(id);
        }

        public IEnumerable<User> GetUsersByName(string? username = "")
        {
           return _unitOfWork.UserRepository.Query(x => x.IsActive && x.UserName.StartsWith(username ?? ""));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.UserRepository.Query(x => x.UserName.StartsWith(""));
        }

        public int LoginUser(string username, string password)
        {
            ArgumentNullException.ThrowIfNull(username);
            ArgumentNullException.ThrowIfNull(password);

            var result = _unitOfWork.UserRepository.LoginUser(username, password);

            if (result == -1)
                throw new LoginException(username);
            return result;
        }
    }
}
