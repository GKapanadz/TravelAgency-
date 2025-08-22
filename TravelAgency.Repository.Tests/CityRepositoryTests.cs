using Microsoft.Data.SqlClient;
using TravelAgency.DTO;
using TravelAgency.Services.Interfaces;

namespace TravelAgency.Repository.Tests;

public class CityRepositoryTests : BaseRepositoryTests<City>
{
    private ICityRepository _repository;

    [SetUp]
    public void SetUp()
    {
        _repository = _unitOfWork!.CityRepository;
    }

    [Test]
    public void TestInsert_ShouldInsert()
    {
        City city = new()
        {
            Name = "Paris",
            CountryID = 1,
        };

        int id = (int)_repository.Insert(city);
        City? result = _repository.Get(id);

        Assert.Greater(id, 0);
        Assert.IsNotNull(result);
        Assert.AreEqual(city.Name, result!.Name);
        Assert.AreEqual(city.CountryID, result.CountryID);

    }

    [Test]
    public void TestInsert_ShouldNotInsert()
    {
        City city = new()
        {
            Name = null,
            CountryID = 0,
        };

        Assert.Throws<SqlException>(() => _repository!.Insert(city));
    }

    [Test]
    public void TestUpdate_ShouldUpdate()
    {
        City? current = _repository.Get(Constants.UpdateTestID);
        Assert.IsNotNull(current);

        current.Name = "Updated" + current.Name;
        current.CountryID = current.CountryID + current.CountryID;
        _repository.Update(current);

        City? updated = _repository.Get(Constants.UpdateTestID);
        Assert.IsNotNull(updated);
        Assert.AreEqual(current.Name,  updated!.Name);
        Assert.AreEqual(current.CountryID, updated!.CountryID);
    }

    [Test]
    public void TestUpdate_ShouldNotupdate()
    {
        City? current = _repository.Get(Constants.UpdateTestID);
        Assert.IsNotNull(current);

        current!.Name = null;
        current.CountryID = -1;

        Assert.Throws<SqlException>(() => _repository.Update(current));
    }

    [Test]
    public void TestDelete_ShouldDelete()
    {
        City? current = _repository!.Get(Constants.DeleteTestID);
        Assert.IsNotNull(current, $"Record with ID {Constants.DeleteTestID} doesn't exist");

        _repository.Delete(Constants.DeleteTestID);

        City? deleted = _repository.Get(Constants.DeleteTestID);
        Assert.IsNull(deleted, $"Record with ID {Constants.DeleteTestID} should not be retried");
    }

    [Test]
    public void TestDelete_ShouldNotDelete()
    {
        City? current = _repository.Get(Constants.DeleteTestID2);
        Assert.IsNotNull(current, $"Record with {Constants.DeleteTestID2} ID doesn't exists");

        _repository.Delete(Constants.DeleteTestID2);
        City? deleted = _repository.Get(Constants.DeleteTestID2);
        Assert.IsNull(deleted, $"Record with {Constants.DeleteTestID2} should not be retried");

        Assert.Throws<SqlException>(() => _repository.Delete(Constants.DeleteTestID2));
    }
}
