using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalProject;

namespace DBTest
{
    [TestClass]
    public class DBTestClass
    {
        DB Database = new DB();

        [TestMethod]
        public void FirstTest()
        {
            ConnectionState dbstat = Database.DBStatus();

            Assert.AreEqual(ConnectionState.Closed, dbstat);
        }

        [TestMethod]
        public void SecondTest()
        {
            ConnectionState dbstat = Database.DBStatus();

            Assert.AreNotEqual(ConnectionState.Open, dbstat);
        }
    }
}
