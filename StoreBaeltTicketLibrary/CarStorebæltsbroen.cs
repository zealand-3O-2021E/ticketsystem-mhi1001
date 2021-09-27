using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Class for the vehicles that go through the Oresundbron ticketing system
    /// </summary>
    public class CarStorebæltsbroen : Vehicle
    {
        public CarStorebæltsbroen(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            Date = date;
            LicensePlate = licensePlate;
            BrobizzUsed = false;
        }
        /// <summary>
        /// Returns the price depending if they went through the bridge on a weekday or weekend and if they used brobizz
        /// </summary>
        /// <returns>A double with the ticket price amount</returns>
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if (BrobizzUsed)
                {

                    double weekendDiscount = 240 - (240 * 0.2);
                    weekendDiscount = +weekendDiscount - (weekendDiscount * 0.05);
                    return weekendDiscount;
                }
                return 240 - (240 * 0.2);
            }

            if (BrobizzUsed)
            {
                return 240 - (240 * 0.05);
            }

            return 240;
        }
        /// <summary>
        /// Car type
        /// </summary>
        /// <returns>String with the car type</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
