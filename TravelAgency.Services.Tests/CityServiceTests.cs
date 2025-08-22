using TravelAgency.Services.Interfaces.Services;
using TravelAgency.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;

namespace TravelAgency.Services.Tests
{
    public class CityServiceTests : BaseServiceTests
    {
        private ICityService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new CityService(_unitOfWork);
        }

        [Test]
        public void TestAdd_ShouldAdd()
        {
            City city = new()
            {
                Name = "Test Name",
                CountryID = 1
            };

            Assert.DoesNotThrow(() => _service.AddCity(city));
            Assert.That(city.CityID, Is.GreaterThan(0));

            City? insertedCity = _service.GetCity(city.CityID);
            Assert.That(city.Name, Is.EqualTo(insertedCity!.Name));
            Assert.That(city.CountryID, Is.EqualTo(insertedCity.CountryID));
        }

        [Test]
        public void TestAdd_ShouldNotAdd()
        {
            City city = new()
            {
                Name = null,
                CountryID = 0
            };

            Assert.Throws<SqlException>(() => _service.AddCity(city));
        }

        [Test]
        public void TestEdit_ShouldEdit()
        {
            City? current = _service.GetCity(Constants.EditTestID);
            Assert.IsNotNull(current);

            current.Name = "Updated Name";
            current.CountryID = 2;
            _service.EditCity(current);

            City? updated = _service.GetCity(current.CityID);
            Assert.That(updated!.CityID, Is.GreaterThan(0));
            Assert.That(current.Name, Is.EqualTo(updated.Name));
            Assert.That(current.CountryID, Is.EqualTo(updated.CountryID));
        }

        [Test]
        public void TestEdit_ShouldNotEdit()
        {
            City? current = _service.GetCity(Constants.EditTestID);
            Assert.IsNotNull(current);

            current.Name = null;
            current.CountryID = 0;

            Assert.Throws<SqlException>(() => _service.EditCity(current));
        }

        [Test]
        public void TestDelete_ShouldDelete()
        {
            City? current = _service.GetCity(Constants.DeleteTestID);
            Assert.IsNotNull(current);

            Assert.DoesNotThrow(() => _service.DeleteCity(Constants.DeleteTestID));
            City? deleted = _service.GetCity(current.CityID);
            Assert.IsNull(deleted);
        }

        [Test]
        public void TestDelete_ShouldNotDelete()
        {
            City? current = _service.GetCity(Constants.DeleteTestID2);
            Assert.IsNotNull(current);

            Assert.DoesNotThrow(() => _service.DeleteCity(current.CityID));
            City? deleted = _service.GetCity(current.CityID);
            Assert.IsNull(deleted);

            Assert.Throws<SqlException>(() => _service.DeleteCity(current.CityID));
        }

        [Test]
        public void TestGetCities_ShouldReturnCities()
        {
            IEnumerable<City> cities = _service.GetCityByName();
            Assert.IsNotNull(cities);

            foreach(var item in cities)
            {
                Assert.IsNotNull(item);
                Assert.IsNotEmpty(item.Name);
            }
        }

        [Test]
        public void TestGetCities_ShouldNotReturnCities()
        {
            IEnumerable<City> cities = _service.GetCityByName("NonExistentName");
            Assert.IsEmpty(cities);
        }

        [Test]
        public void TestGetCity_ShouldReturnCity()
        {
            City? city = _service.GetCity(Constants.GetTestID);
            Assert.IsNotNull(city);
        }

        [Test]
        public void TestGetCity_ShouldNotReturnCity()
        {
            City? city = _service.GetCity(0);
            Assert.IsNull(city);
        }
    }
}
