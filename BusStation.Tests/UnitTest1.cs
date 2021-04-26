using System.IO;
using System.Linq;
using BusStation.DAL.Entities;
using BusStation.DAL.Interfaces;
using BusStation.DAL.UnitsOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusStation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        IUnitOfWork _storage;
        [TestInitialize]
        public void SetUp()
        {
            string connection = "database=busstation;server=127.0.0.1;port=3306;user id=root;pwd=admin";
            _storage = new BusStationDbUnitOfWork(connection);
        }

        [TestMethod]
        public void UsersGetAllTest()
        {
            var userTypes = _storage.Users.Get();
            Assert.AreEqual(2, userTypes.Count());
        }
        [TestMethod]
        public void BusCategoriesCreateTest()
        {
            _storage.BusCategories.Create(new BusCategory
            {
                Name = "category name",
                PriceForOneKm = 12
            });

            var cat = _storage.BusCategories.Get().Last();

            Assert.AreEqual("category name", cat.Name);

            _storage.BusCategories.Delete(_storage.BusCategories.Get().Last().Id);
        }
        [TestMethod]
        public void BusCategoriesDeleteTest()
        {
            _storage.BusCategories.Create(new BusCategory
            {
                Name = "category name",
                PriceForOneKm = 12
            });

            var cat = _storage.BusCategories.Get().Last();

            Assert.AreEqual("category name", cat.Name);

            _storage.BusCategories.Delete(_storage.BusCategories.Get().Last().Id);
        }
        [TestMethod]
        public void BusCategoriesUpdateTest()
        {
            BusCategory qq = new BusCategory
            {
                Name = "name",
                PriceForOneKm = 12
            };

            _storage.BusCategories.Create(qq);

            var q = _storage.BusCategories.Get().Last();

            q.Name = "new name";

            _storage.BusCategories.Update(q);

            Assert.AreNotEqual(_storage.BusCategories.Get().Last().Name, qq.Name);

            _storage.Buses.Delete(_storage.BusCategories.Get().Last().Id);
        }

        [TestMethod]
        public void GetAllAndAddStopsTest()
        {
            Stop stop1 = new Stop
            {
                Name = "stop1",
            };

            Stop stop2 = new Stop
            {
                Name = "stop2"
            };

            _storage.Stops.Create(stop1);
            _storage.Stops.Create(stop2);
            Assert.AreEqual(2, _storage.Stops.Get().Where(x => x.Name.Equals("stop1") || x.Name.Equals("stop2")).Count());
        }

    }
}
