using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repository.Tests
{
    public class UserRepositoryTests : BaseRepositoryTests<User>
    {
        private IUserRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.UserRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            User user = new()
            {
                UserID = 4,
                UserName = "Test Name",
                Password = "pass123",
                UserRole = 2
            };

            int id = (int)_repository!.Insert(user);
            User? result = _repository!.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(user.UserName, result!.UserName);
            Assert.AreEqual(user.UserRole, result!.UserRole);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            User? user = new()
            {
                UserID = 3,
                UserName = null,
                Password = null,
                UserRole = 0
            };

            Assert.Throws<SqlException>(() => _repository.Insert(user));
        }

        [Test]
        public void TestUpdate_ShoulUpdate()
        {
            User? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.UserName = "Updated" + current.UserName;
            current.Password = "Updated" + current.Password;
            current.UserRole = 2;
            _repository.Update(current);

            User? Updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(Updated);
            Assert.AreEqual(current.UserName, Updated!.UserName);
            Assert.AreEqual(current.UserRole, Updated!.UserRole);
        }

        [Test]
        public void TestUpdate_ShouldNotUpdate()
        {
            User? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.UserName = null;
            current.Password = null;
            current.UserRole = 0;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            User? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exists");

            _repository.Delete(current.UserID);
            User? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record wiht ID {Constants.DeleteTestID} should not be retried ");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            User? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exists");

            _repository.Delete(Constants.DeleteTestID2);
            User? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record wiht ID {Constants.DeleteTestID} should not be retried ");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }

        [Test]
        public void TestQuery_ShouldReturnUsersWithSpecificRole()
        {
            IEnumerable<User> users = _repository!.Query(user => user.UserRole == 1);

            Assert.IsNotNull(users);

            foreach (var user in users)
            {
                Assert.AreEqual(1, user.UserRole, $"User with Username {user.UserName} does not have the expected UserRole.");
            }
        }

        [Test]
        public void TestLogin_ShouldLogin()
        {
            var result = _repository.LoginUser("admin", "admin123");
            Assert.Greater(result, 0, "Login failed");
        }

        [Test]
        public void TestLogin_ShouldNotLogin()
        {
            var result = _repository.LoginUser("adddmin", "WrongPass");
            Assert.AreEqual(-1, result, "Login should not be successful.");
        }
    }
}
