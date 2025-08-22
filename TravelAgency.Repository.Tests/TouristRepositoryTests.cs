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
    public class TouristRepositoryTests : BaseRepositoryTests<Tourist>
    {
        private ITouristRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = _unitOfWork!.TouristRepostory;
        }

        [Test]
        public void TestInsert_ShouldInsert()
        {
            Tourist tourist = new()
            {
                TourID = 1,
                FirstName = "Test Name",
                LastName = "Test LastName",
                BirthDate = DateTime.Today.AddYears(-30),
                ContactPhone = "234-567-8901",
            };

            int id = (int)_repository.Insert(tourist);
            Tourist? result = _repository.Get(id);

            Assert.Greater(id, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(tourist!.TourID, result.TourID);
            Assert.AreEqual(tourist!.FirstName, result.FirstName);
            Assert.AreEqual(tourist!.LastName, result.LastName);
            Assert.AreEqual(tourist!.BirthDate, result!.BirthDate);
            Assert.AreEqual(tourist.ContactPhone, result!.ContactPhone);
        }

        [Test]
        public void TestInsert_ShouldNotInsert()
        {
            Tourist? tourist = new()
            {
                TourID = 0,
                FirstName = null,
                LastName = null,
                BirthDate = DateTime.Today.AddYears(-100),
                ContactPhone = ""
            };

            Assert.Throws<SqlException>(() => _repository.Insert(tourist));
        }

        [Test]
        public void TestUpdate_ShouldUpdate()
        {
            Tourist? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.TourID = current.TourID + 1;
            current.FirstName = "Updated " + current.FirstName;
            current.LastName = "Updated " + current.LastName;
            current.BirthDate = DateTime.Today.AddYears(-40);
            current.ContactPhone = "Updated Number";
            _repository.Update(current);

            Tourist? updated = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(updated);
            Assert.AreEqual(current!.TourID, updated!.TourID);
            Assert.AreEqual(current!.FirstName, updated!.FirstName);
            Assert.AreEqual(current!.LastName, updated!.LastName);
            Assert.AreEqual(current!.BirthDate, updated!.BirthDate);
            Assert.AreEqual(current!.ContactPhone, updated!.ContactPhone);
        }

        [Test]
        public void TestUpdate_ShooulNotupdate()
        {
            Tourist? current = _repository.Get(Constants.UpdateTestID);
            Assert.IsNotNull(current);

            current.TourID = 0;
            current.FirstName = null;
            current.LastName = null;
            current.BirthDate = DateTime.Today.AddYears(-100);
            current.ContactPhone = "";

            Assert.Throws<SqlException>(() => _repository.Update(current));
        }
    }
}
