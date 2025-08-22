using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces.Repositories;

namespace TravelAgency.Repository.Tests
{
    public class PositionRepositoryTests : BaseRepositoryTests<Position>
    {
        private IPositionRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.PositionRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Position? position = new()
            {
                Name = "Test Name",
                Description = "Test Description",
                Salary = 3000.40
            };

            int id = (int)_repository.Insert(position);
            Position? result = _repository.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(position!.Name, result!.Name);
            Assert.AreEqual(position!.Description, result.Description);
            Assert.AreEqual(position!.Salary, result.Salary);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Position? position = new()
            {
                Name = null,
                Description = null,
                Salary = 0
            };

            Assert.Throws<SqlException>(() => _repository.Insert(position));
        }

        [Test]
        public void TestUpdateShouldUpdate()
        {
            Position? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated";
            current.Description = "Updated";
            current.Salary = 1000;
            _repository.Update(current);

            Position? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current.Name!, updated.Name!);
        }

        [Test]
        public void TestUpdateShouldNotUpdate()
        {
            Position? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = null;
            current.Description = null;
            current.Salary = 0;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Position? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist ");

            _repository.Delete(Constants.DeleteTestID);

            Position? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            Position? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exist ");

            _repository.Delete(Constants.DeleteTestID2);

            Position? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not be retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
