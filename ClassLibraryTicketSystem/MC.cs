using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {

        public MC(string licensePlate, DateTime date) 
            :base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }


        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
