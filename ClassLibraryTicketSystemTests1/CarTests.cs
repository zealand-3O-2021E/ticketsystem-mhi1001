using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarLicensePlateArgumentException()
        {
            //Arrange & Act
            Car c1 = new Car("12345678", DateTime.Now);

            //Assert
           Assert.Fail();
        }

        /// <summary>
        /// Tests if the car method returns its designated price which is 240.
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            Car c1 = new Car("32ha", DateTime.Now);
            //Act
            double actualPrice = c1.Price();
            //Assert
            Assert.AreEqual(240, actualPrice);
        }
        [TestMethod()]
        public void PriceBroBizzTest()
        {
            //Arrange
            Car c1 = new Car("32ha", DateTime.Now);
            //Act
            c1.BrobizzUsed = true;
            double actualPrice = c1.Price();
            //Assert -> 5% of 240 = 12 so 240-12 = 228
            Assert.AreEqual(228, actualPrice,0.01);
        }

        /// <summary>
        /// Tests if its returning the right type of vehicle
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            Car c1 = new Car("32ha", DateTime.Now);
            //Act
            string actualType = c1.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualType);
        }


    }
}