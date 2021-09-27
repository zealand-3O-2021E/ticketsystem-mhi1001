using System;
using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTicketSystemTests1
{
    [TestClass()]
    public class MCTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void McLicensePlateArgumentException()
        {
            //Arrange & Act
            MC mc1 = new MC("12345678", DateTime.Now);
            
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            MC mc1 = new MC("32ha", DateTime.Now);
            //Act
            double actualPrice = mc1.Price();
            //Assert
            Assert.AreEqual(125, actualPrice);
        }

        [TestMethod()]
        public void PriceBroBizzTest()
        {
            //Arrange
            MC mc1 = new MC("32ha", DateTime.Now);
            //Act
            mc1.BrobizzUsed = true;
            double actualPrice = mc1.Price();
            //Assert
            Assert.AreEqual(118.75, actualPrice,0.01);
        }

        /// <summary>
        /// Tests if its returning the right type of vehicle
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            MC mc1 = new MC("32ha", DateTime.Now);
            //Act
            string actualType = mc1.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualType);
        }
    }
}