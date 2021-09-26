using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {

        public MC(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }


        public double Price()
        {
            return 125;
        }

        public string VehicleType()
        {
            return "MC";
        }
    }
}
