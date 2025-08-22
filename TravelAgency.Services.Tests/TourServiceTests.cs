using TravelAgency.Services.Interfaces.Services;
using TravelAgency.DTO;
using Microsoft.Data.SqlClient;

namespace TravelAgency.Services.Tests
{
    public class TourServiceTests : BaseServiceTests
    {
        private ITourService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new TourService(_unitOfWork!);
        }

        [Test]
        public void TestAdd_ShouldAdd()
        {
            Tour? tour = new()
            {
                Name = "Test Name",
                Duration = 5,
                TotalPrice = 2500,
                StartDate = DateTime.Today.AddDays(-5),
                EndDate = DateTime.Today.AddDays(1)
            };

            Assert.DoesNotThrow(() => _service.AddTour(tour));
            Assert.That(tour.TourID, Is.GreaterThan(0));

            Tour? insertedTour = _service.GetTour(tour.TourID);
            Assert.That(insertedTour.TourID, Is.GreaterThan(0));
            Assert.That(tour.Name, Is.EqualTo(insertedTour.Name));
            Assert.That(tour.Duration, Is.EqualTo(insertedTour.Duration));
            Assert.That(tour.TotalPrice, Is.EqualTo(insertedTour.TotalPrice));
            Assert.That(tour.StartDate, Is.EqualTo(insertedTour.StartDate));
            Assert.That(tour.EndDate, Is.EqualTo(insertedTour.EndDate));
        }

        [Test]
        public void TestAdd_ShouldNotAdd()
        {
            Tour? tour = new()
            {
                Name = null,
                Duration = 0,
                TotalPrice = 0,
                StartDate = DateTime.Today.AddDays(-5),
                EndDate = DateTime.Today.AddDays(1)
            };

            Assert.Throws<SqlException>(() => _service.AddTour(tour));
        }

        [Test]
        public void TestEdit_ShouldEdit()
        {
            Tour? current = _service.GetTour(Constants.EditTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated Name";
            current.Duration = 10;
            current.TotalPrice = 5000;
            current.StartDate = DateTime.Today.AddDays(-10);
            current.EndDate = DateTime.Today.AddDays(5);
            _service.EditTour(current);

            Tour? updated = _service.GetTour(current.TourID);
            Assert.That(updated!.TourID, Is.GreaterThan(0));
            Assert.That(current.Name, Is.EqualTo(updated.Name));
            Assert.That(current.Duration, Is.EqualTo(updated.Duration));
            Assert.That(current.TotalPrice, Is.EqualTo(updated.TotalPrice));
            Assert.That(current.StartDate, Is.EqualTo(updated.StartDate));
            Assert.That(current.EndDate, Is.EqualTo(updated.EndDate));
        }

        [Test]
        public void TestEdit_ShouldNotEdit()
        {
            Tour? current = _service.GetTour(Constants.EditTestID);
            Assert.IsNotNull(current);

            current.Name = null;
            current.Duration = 0;
            current.TotalPrice = 0;
            current.StartDate = DateTime.Today.AddDays(-10);
            current.EndDate = DateTime.Today.AddDays(5);

            Assert.Throws<SqlException>(() => _service.EditTour(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            Tour? current = _service.GetTour(1);
            Assert.IsNotNull(current);

            Assert.DoesNotThrow(() => _service.DeleteTour(current.TourID));
            Tour? deleted = _service.GetTour(current.TourID);
            Assert.IsNull(deleted);
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            Tour? current = _service.GetTour(2);
            Assert.IsNotNull(current);

            Assert.DoesNotThrow(() => _service.DeleteTour(current.TourID));
            Tour? deleted = _service.GetTour(current.TourID);
            Assert.IsNull(deleted);

            Assert.Throws<SqlException>(() => _service.DeleteTour(current.TourID));
        }

        [Test]
        public void TestGetTours_ShouldReturnTours()
        {
            IEnumerable<Tour> tours = _service.GetToursByName();
            Assert.IsNotNull(tours);

            foreach(var item in tours)
            {
                Assert.IsNotNull(item);
                Assert.IsNotEmpty(item.Name);
            }
        }

        [Test]
        public void TestGetTours_ShouldNotReturnTours()
        {
            IEnumerable<Tour> tours = _service.GetToursByName("NonExistentName");
            Assert.IsEmpty(tours);
        }

        [Test]
        public void TestGetTour_ShouldReturnTour()
        {
            Tour? tour = _service.GetTour(3);
            Assert.IsNotNull(tour);
        }

        [Test]
        public void TestGetTour_ShouldNotReturnTour()
        {
            Tour? tour = _service.GetTour(100);
            Assert.IsNull(tour);
        }
    }
}
