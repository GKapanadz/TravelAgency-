using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repository.Tests
{
    public  class CountryRepositoryTests : BaseRepositoryTests<Country>
    {
        private ICountryRepository _repository;
        
        [SetUp]
        public void Setup()
        {
            _repository = _unitOfWork!.CountryRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Country? country = new()
            {
                Name = "France",
            };

            int id = (int)_repository.Insert(country);
            Country? result = _repository.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(country!.Name, result.Name!);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Country? country = new()
            {
                Name = null,
            };

            Assert.Throws<SqlException>(() => _repository.Insert(country));
        }

        [Test]
        public void TestUpdate_ShoulUpdate()
        {
            Country? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated" + current.Name;
            _repository.Update(current);

            Country? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current.Name!, updated.Name!);
        }

        [Test]
        public void TestUpdate_ShouldNotupdate()
        {
            Country? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current!.Name = null;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Country? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist");

            _repository.Delete(Constants.DeleteTestID);

            Country? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            Country? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exist");

            _repository.Delete(Constants.DeleteTestID2);

            Country? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not be retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
