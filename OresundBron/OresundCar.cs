using System;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundCar : Vehicle
    {
        public OresundCar(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
            BrobizzUsed = false;
        }

        public override double Price()
        {
            if (BrobizzUsed)
            {
                return 161;
            }
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
