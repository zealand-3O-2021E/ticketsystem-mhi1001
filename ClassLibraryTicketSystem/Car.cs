using System;

namespace ClassLibraryTicketSystem
{


    public class Car : Vehicle
    {

        /// <summary>
        /// Car Constructor that takes two parameters
        /// </summary>
        /// <param name="licensePlate">This is the license plate of the object</param>
        /// <param name="date">This is the date of creation or registration</param>
        public Car(string licensePlate, DateTime date) 
            : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }


        public override double Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
