using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        protected string LicensePlate { get; set; }
        protected DateTime Date { get; set; }


        public abstract double Price();

        public abstract string VehicleType();
    }
}
