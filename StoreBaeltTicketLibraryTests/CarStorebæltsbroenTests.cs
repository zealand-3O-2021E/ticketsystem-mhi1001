using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class CarStorebæltsbroenTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarStorebæltsbroenLicensePlateArgumentExceptionTest()
        {
            //Arrange & Act
            CarStorebæltsbroen c1 = new CarStorebæltsbroen("12345678", DateTime.Now);

            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void CarStorebæltsbroenWeekendWITHBroBizzPriceTest()
        {
            //Arrange
            CarStorebæltsbroen c1 = new CarStorebæltsbroen("32ha", DateTime.Parse("26/09/2021"));
            //Act
            c1.BrobizzUsed = true;
            double actualPrice = c1.Price();

            //Assert -> Weekend discount = 48 so 240-48=192 then apply bro bizz discount 192-9.6 = 182.4

            Assert.AreEqual(182.4, actualPrice, 0.01);
        }
        [TestMethod()]
        public void CarStorebæltsbroenWeekendPriceTest()
        {
            //Arrange
            CarStorebæltsbroen c1 = new CarStorebæltsbroen("32ha", DateTime.Parse("26/09/2021"));
            //Act
            c1.BrobizzUsed = false;
            double actualPrice = c1.Price();

            //Assert

            Assert.AreEqual(192, actualPrice, 0.01);
        }
        [TestMethod()]
        public void CarStorebæltsbroenWithBroBizz()
        {
            //Arrange
            CarStorebæltsbroen c1 = new CarStorebæltsbroen("32ha", DateTime.Parse("28/09/2021"));
            //Act
            c1.BrobizzUsed = true;
            double actualPrice = c1.Price();

            //Assert 
            Assert.AreEqual(228, actualPrice, 0.01);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            CarStorebæltsbroen c1 = new CarStorebæltsbroen("32ha", DateTime.Now);
            //Act
            string actualType = c1.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualType);
        }
    }
}