using System;

namespace ClassLibraryTicketSystem
{


    public class Car
    {

        /// <summary>
        /// Car Constructor that takes two parameters
        /// </summary>
        /// <param name="licensePlate">This is the license plate of the object</param>
        /// <param name="date">This is the date of creation or registration</param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }


        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Method that can be called to know the price of a ticket for the object
        /// </summary>
        /// <returns>A double, which is the value of the ticket for this object</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Returns the type of vehicle
        /// </summary>
        /// <returns>Returns a string with the type of the vehicle</returns>
        public string VehicleType()
        {
            return "Car";
        }

        
    }
}
