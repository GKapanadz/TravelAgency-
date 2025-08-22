using TravelAgency.Services.Interfaces.Services;
using TravelAgency.DTO;
using Microsoft.Data.SqlClient;
using TravelAgency.Services.Exceptions;

namespace TravelAgency.Services.Tests
{
    public class UserServiceTests : BaseServiceTests
    {
        private IUserService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new UserService(_unitOfWork);
        }

        [Test]
        public void TestAddUser_ShouldAddUser()
        {
            User? newUser = new()
            {
                UserID = 4,
                UserName = "TestUser",
                Password = "TestPassword",
                UserRole = 1,
            };

            Assert.DoesNotThrow(() => _service.AddUser(newUser));
            Assert.That(newUser.UserID, Is.GreaterThan(0));

            User? insertedUser = _service.GetUser(newUser.UserID);
            Assert.That(insertedUser, Is.Not.Null);
            Assert.That(insertedUser.UserName, Is.EqualTo(newUser.UserName));
            Assert.That(insertedUser.UserRole, Is.EqualTo(newUser.UserRole));
        }

        [Test]
        public void TestAddUser_ShouldNotAddUser()
        {
            User? user = new()
            {
                UserName = "TestUser",
                Password = null,
                UserRole = 1,
            };

            Assert.Throws<SqlException>(() => _service!.AddUser(user));
        }

        [Test]
        public void TestEditUser_ShouldEditUser()
        {
            User? current = _service!.GetUser(3);
            Assert.IsNotNull(current);

            current.UserID = 3;
            current.UserRole = 3;
            current!.Password = "123Pass++";
            current.UserName = "Updated " + current.UserName;

            _service!.EditUser(current);

            User? updated = _service.GetUser(current.UserID);
            Assert.IsNotNull(updated);
            Assert.That(current.UserID, Is.EqualTo(updated!.UserID));
            Assert.That(current.UserName, Is.EqualTo(updated!.UserName));
            Assert.That(current.UserRole, Is.EqualTo(updated!.UserRole));
        }


        [Test]
        public void TestEditUser_ShouldNotEditUser()
        {
            User? current = _service!.GetUser(3);
            Assert.IsNotNull(current);

            current.UserID = 3;
            current!.UserRole = 3;
            current!.Password = "123Pass++";
            current!.UserName = null;
            Assert.Throws<SqlException>(() => _service!.EditUser(current));
        }

        [Test]
        public void TestGetUser_shouldReturnUser()
        {
            User? user = _service!.GetUser(1);
            Assert.IsNotNull(user);
        }

        [Test]
        public void TestGetUser_ShouldNotReturnUser()
        {
            User? user = _service!.GetUser(0);
            Assert.IsNull(user);
        }

        [Test]
        public void TestGetUsers_ShouldReturnUsers()
        {
            IEnumerable<User> users = _service!.GetUsersByName();
            Assert.IsNotEmpty(users);
            foreach (var item in users)
            {
                Assert.IsNotNull(item);
                Assert.IsNotEmpty(item.UserName);
            }
        }

        [Test]
        public void TestGetUsers_ShouldNotReturnUsers()
        {
            IEnumerable<User> users = _service!.GetUsersByName("NonExistentUser");
            Assert.IsEmpty(users);
        }

        [Test]
        public void TestLogin_ShouldLoginUser()
        {
            int result = _service!.LoginUser("admin", "admin123");
            Assert.Greater(result, 0, "Login failed.");
        }

        [Test]
        public void TestLogout_ShouldNotLoginUser()
        {
            Assert.Throws<LoginException>(() => _service!.LoginUser("admin", "wrongpassword"));
        }
    }
}
