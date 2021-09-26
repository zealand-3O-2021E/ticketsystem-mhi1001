using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Car Constructor that takes two parameters
        /// </summary>
        /// <param name="licensePlate">This is the license plate of the object</param>
        /// <param name="date">This is the date of creation or registration</param>
        public MC(string licensePlate, DateTime date) 
            :base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Method that overrides the base that shows the price.
        /// If this instance has used brobizz it will give a discount on the price
        /// </summary>
        /// <returns>double type that is the price</returns>
        public override double Price()
        {
            
            if (BrobizzUsed)
            {
                return 125 - (125 * 0.05);
            }

            return 125;
        }
        /// <summary>
        /// Method that outputs type of the vehicle
        /// </summary>
        /// <returns>Returns a string that says the type of the vehicle</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
