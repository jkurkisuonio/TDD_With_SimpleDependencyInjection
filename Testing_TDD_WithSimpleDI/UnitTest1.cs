using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_With_SimpleDependencyInjection;
using Testing_TDD_WO_SimpleDI;

namespace Testing_TDD_WithSimpleDI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - järjestetään tilanne testille otolliseksi.
            var databaseConnection = new DatabaseConnectionImitation();
            var user = new User(databaseConnection);
            // Act - suoritetaan toimenpiteet, joita halutaan testata.
            var etunimi = user.FirstName;
            // Assert - todennetaan, miten testi meni.
            Assert.IsNotNull(etunimi);
        }

        public void TestThatTextIsTrimmed()
        {


        }

    }
}
