using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Instance field for the license plate property so we can add logic. Auto-Properties do not support logic.
        /// </summary>
        private string _licensePlate;

        protected Vehicle(string licensePlate, DateTime date)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 chars");
            }

            LicensePlate = licensePlate;
            Date = date;
        }

        protected string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 chars");
                }

                _licensePlate = value;
            }

        }

        protected DateTime Date { get; set; }

        public abstract double Price();

        public abstract string VehicleType();
    }
}
