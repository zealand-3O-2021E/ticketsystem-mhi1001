using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBron
{
    public class OresundMc : Vehicle
    {
        public OresundMc(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
            BrobizzUsed = false;
        }

        public override double Price()
        {
            if (BrobizzUsed)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
