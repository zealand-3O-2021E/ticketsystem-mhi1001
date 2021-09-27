using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace OresundBronTests
{
    [TestClass()]
    public class OresundCarTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void OresundCarLicensePlateArgumentExceptionTest()
        {
            //Arrange & Act
            OresundCar c1 = new OresundCar("12345678", DateTime.Now);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            OresundCar c1 = new OresundCar("32ha", DateTime.Now);
            //Act
            double actualPrice = c1.Price();
            //Assert
            Assert.AreEqual(410, actualPrice);
        }
        [TestMethod()]
        public void PriceBroBizzTest()
        {
            //Arrange
            OresundCar c1 = new OresundCar("32ha", DateTime.Now);
            //Act
            c1.BrobizzUsed = true;
            double actualPrice = c1.Price();
            //Assert
            Assert.AreEqual(161, actualPrice, 0.01);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundCar c1 = new OresundCar("32ha", DateTime.Now);
            //Act
            string actualType = c1.VehicleType();
            //Assert
            Assert.AreEqual("Oresund Car", actualType);
        }

    }
}