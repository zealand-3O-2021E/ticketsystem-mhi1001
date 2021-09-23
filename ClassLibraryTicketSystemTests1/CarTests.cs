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
            Assert.AreEqual(240,actualPrice);
        }


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