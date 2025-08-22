using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repository.Tests
{
    public class EmployeeRepostioryTests : BaseRepositoryTests<Employee>
    {
        private IEmployeeRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.EmployeeRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Employee? employee = new()
            {
                FirstName = "Jhon",
                LastName = "Dhoe",
                Email = "Test.doe@example.com",
                AddressLine1 = "123 Maple Street",
                AddressLine2 = " N'Apt 4B",
                TourID = 1,
                PhoneNumber = "555111222",
                BirthDate = DateTime.Today.AddYears(-50),
                HireDate = DateTime.Today.AddYears(-5),
                PositionID = 3

            };

            int id = (int)_repository.Insert(employee);
            Employee? result = _repository.Get(id);

            Assert.IsNotNull(result);
            Assert.Greater(id, 0);
            Assert.AreEqual(employee!.FirstName, result!.FirstName);
            Assert.AreEqual(employee!.LastName, result!.LastName);
            Assert.AreEqual(employee!.AddressLine1, result!.AddressLine1);
            Assert.AreEqual(employee!.AddressLine2, result!.AddressLine2);
            Assert.AreEqual(employee!.TourID, result!.TourID);
            Assert.AreEqual(employee!.PhoneNumber, result!.PhoneNumber);
            Assert.AreEqual(employee!.BirthDate, result!.BirthDate);
            Assert.AreEqual(employee!.HireDate, result!.HireDate);
            Assert.AreEqual(employee!.PositionID, result!.PositionID);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Employee? employee = new()
            {
                FirstName = null,
                LastName = null,
                Email = null,
                AddressLine1 = null,
                AddressLine2 = null,
                TourID = 0,
                PhoneNumber = null,
                BirthDate = DateTime.Today.AddYears(-50),
                HireDate = DateTime.Today.AddYears(-5),
                PositionID = 0
            };

            Assert.Throws<SqlException>(() => _repository.Insert(employee));
        }

        [Test]
        public void TestUpdate_ShouldUpdate()
        {
            Employee? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.FirstName = "Jhon";
            current.LastName = "Dhoe";
            current.Email = "Test.doe@examplle.com";
            current.AddressLine1 = "123 Maple Street";
            current.AddressLine2 = " N'Apt 4B";
            current.TourID = 1;
            current.PhoneNumber = "555111222";
            current.BirthDate = DateTime.Today.AddYears(-50);
            current.HireDate = DateTime.Today.AddYears(-5);
            current.PositionID = 3;
            
            _repository.Update(current);
            Employee? updated = _repository.Get(Constants.UpdateTestID);

            Assert.IsNotNull(updated);
            Assert.AreEqual(current!.FirstName, updated!.FirstName);
            Assert.AreEqual(current!.LastName, updated!.LastName);
            Assert.AreEqual(current!.AddressLine1, updated!.AddressLine1);
            Assert.AreEqual(current!.AddressLine2, updated!.AddressLine2);
            Assert.AreEqual(current!.TourID, updated!.TourID);
            Assert.AreEqual(current!.PhoneNumber, updated!.PhoneNumber);
            Assert.AreEqual(current!.BirthDate, updated!.BirthDate);
            Assert.AreEqual(current!.HireDate, updated!.HireDate);
            Assert.AreEqual(current!.PositionID, updated!.PositionID);
        }

        [Test]
        public void TestUpdate_ShouldNotUpdate()
        {
            Employee? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.FirstName = null;
            current.LastName = null;
            current.Email = null;
            current.AddressLine1 = null;
            current.AddressLine2 = null;
            current.TourID = 0;
            current.PhoneNumber = null;
            current.BirthDate = DateTime.Today.AddYears(-50);
            current.HireDate = DateTime.Today.AddYears(-5);
            current.PositionID = 0;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Employee? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record wiht ID {Constants.DeleteTestID} doesn't exist");

            _repository.Delete(Constants.DeleteTestID);

            Employee? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not retried");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            Employee? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record wiht ID {Constants.DeleteTestID2} doesn't exist");

            _repository.Delete(Constants.DeleteTestID2);

            Employee? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
