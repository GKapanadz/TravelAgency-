using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repository.Tests
{
    public class TourStopRepositoryTests : BaseRepositoryTests<TourStop>
    {
        private ITourStopRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.TourStopRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            TourStop? tourStop = new()
            {   
                TourID = 1,
                CityID = 1,
                DaysSpent = 3,
            };

            int id = (int)_repository.Insert(tourStop);
            TourStop? result = _repository.Get(id);
            
            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(tourStop!.TourID, result!.TourID);
            Assert.AreEqual(tourStop!.CityID, result!.CityID);
            Assert.AreEqual(tourStop!.DaysSpent, result!.DaysSpent);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            TourStop? tourStop = new()
            {
                TourID = -1,
                CityID = -2,
                DaysSpent = 0,
            };

            Assert.Throws<SqlException>(() => _repository.Insert(tourStop));
        }

        [Test]
        public void TestUpdate_ShouldUpdate()
        {
            TourStop? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.TourID = current.TourID + 1;
            current.CityID = 4;
            current.DaysSpent = 5;
            _repository.Update(current);

            TourStop? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current!.TourID, updated!.TourID);
            Assert.AreEqual(current!.CityID, updated!.CityID);
            Assert.AreEqual(current!.DaysSpent, updated!.DaysSpent);
        }

        [Test]
        public void TestUpdate_ShouldNotUpdate()
        {
            TourStop? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.TourID = 0;
            current.CityID = 0;
            current.DaysSpent = 0;

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            TourStop? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist");

            _repository.Delete(Constants.DeleteTestID);
            TourStop? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            TourStop? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exist");

            _repository.Delete(Constants.DeleteTestID2);
            TourStop? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not be retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
