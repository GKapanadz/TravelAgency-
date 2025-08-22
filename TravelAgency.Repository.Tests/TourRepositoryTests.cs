using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repository.Tests
{
    public class TourRepositoryTests : BaseRepositoryTests<Tour>
    {
        private ITourRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork.TourRepository;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Tour? tour = new()
            {
                Name = "Test Name",
                Duration = 5,
                TotalPrice = 500,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(5),
            };

            int id = (int)_repository.Insert(tour);
            Tour? result = _repository.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(tour!.Name, result.Name);
            Assert.AreEqual(tour!.Duration, result!.Duration);
            Assert.AreEqual(tour!.StartDate, result!.StartDate);
            Assert.AreEqual(tour!.EndDate, result!.EndDate);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Tour? tour = new()
            {
                Name = null,
                Duration = 0,
                StartDate = DateTime.Today.AddYears(-100),
                EndDate = DateTime.Today.AddYears(-200),
            };

            Assert.Throws<SqlException>(() => _repository.Insert(tour));
        }

        [Test]
        public void TestUpdate_ShouldUpdate()
        {
            Tour? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated Name";
            current.Duration = 6;
            current.StartDate = DateTime.Today;
            current.EndDate = DateTime.Today.AddDays(5);
            _repository.Update(current);

            Tour? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current!.Name, updated!.Name);
            Assert.AreEqual(current!.Duration, updated!.Duration);
            Assert.AreEqual(current!.StartDate, updated!.StartDate);
            Assert.AreEqual(current!.EndDate, updated!.EndDate);
        }

        [Test]
        public void TestUpdate_ShouldNotUpdate()
        {
            Tour? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.Name = null;
            current.Duration = 0;
            current.StartDate = DateTime.Today.AddYears(-100);
            current.EndDate = DateTime.Today.AddYears(-200);

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Tour? current = _repository.Get(Constants.DeleteTestID);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist");

            _repository.Delete(Constants.DeleteTestID);
            Tour? deleted = _repository.Get(Constants.DeleteTestID);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
        }

        [Test]
        public void TestDelete_ShoulDelete()
        {
            Tour? current = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID2} doesn't exist");

            _repository.Delete(Constants.DeleteTestID2);
            Tour? deleted = _repository.Get(Constants.DeleteTestID2);
            Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID2} should not be retried");

            Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
        }
    }
}
