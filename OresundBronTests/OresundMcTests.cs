using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace OresundBronTests
{
    [TestClass()]
    public class OresundMcTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void OresundMcLicensePlateArgumentExceptionTest()
        {
            //Arrange & Act
            OresundMc c1 = new OresundMc("12345678", DateTime.Now);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            OresundMc c1 = new OresundMc("32ha", DateTime.Now);
            //Act
            double actualPrice = c1.Price();
            //Assert
            Assert.AreEqual(210, actualPrice);
        }
        [TestMethod()]
        public void PriceBroBizzTest()
        {
            //Arrange
            OresundMc c1 = new OresundMc("32ha", DateTime.Now);
            //Act
            c1.BrobizzUsed = true;
            double actualPrice = c1.Price();
            //Assert
            Assert.AreEqual(73, actualPrice, 0.01);
        }
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            OresundMc c1 = new OresundMc("32ha", DateTime.Now);
            //Act
            string actualType = c1.VehicleType();
            //Assert
            Assert.AreEqual("Oresund MC", actualType);
        }
    }
}