using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repository.Tests
{
    public class HotelRepositoryTests : BaseRepositoryTests<Hotel>
    {
        private IHotelRepository _repository;
        
        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.HotelRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Hotel? hotel = new()
            {
                Name = "Test Name",
                CityID = 1,
                Stars = 3,
                PerNightPrice = 50.22,
                Dining = true,
                AdditionalServices = null,
            };

            int id = (int)_repository.Insert(hotel);
            Hotel? result = _repository.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(hotel!.Name, result!.Name);
            Assert.AreEqual(hotel!.CityID, result!.CityID);
            Assert.AreEqual(hotel!.Stars, result!.Stars);
            Assert.AreEqual(hotel!.PerNightPrice, result!.PerNightPrice);
            Assert.AreEqual(hotel!.Dining, result!.Dining);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Hotel? hotel = new()
            {
                Name = null,
                CityID = -1,
                Stars = 6,
                PerNightPrice = 0,
            };

            Assert.Throws<SqlException>(() => _repository.Insert(hotel));
        }

        [Test]
        public void TestUpdate_ShouldUpdate()
        {
            Hotel? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated " + current.Name;
            current.CityID = Constants.UpdateTestID;
            current.Stars = 4;
            current.PerNightPrice = 60.23;
            _repository.Update(current);

            Hotel? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current!.Name, updated!.Name);
            Assert.AreEqual(current!.CityID, updated!.CityID);
            Assert.AreEqual(current!.Stars, updated!.Stars);
            Assert.AreEqual(current!.PerNightPrice, updated.PerNightPrice);
        }

        [Test]
        public void TestUpdate_ShouldNotupdate()
        {
            Hotel? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = null;
            current.CityID = -1;
            current.Stars = 6;
            current.PerNightPrice = 0;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Hotel? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist");

            _repository.Delete(Constants.DeleteTestID);
            Hotel? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            Hotel? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exist");

            _repository.Delete(Constants.DeleteTestID2);
            Hotel? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not be retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
