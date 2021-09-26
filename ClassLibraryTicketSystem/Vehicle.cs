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

        /// <summary>
        /// Base Class constructor, it takes two parameters.
        /// It checks upon creating if the license plate is not longer than 7 chars.
        /// If its longer than 7 chars it throws an exception
        /// Takes a date for the registration date
        /// It also initializes the brobizz discount. the default is false.
        /// </summary>
        /// <param name="licensePlate">License plate of the vehicle</param>
        /// <param name="date">Date of the reg</param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 chars");
            }

            LicensePlate = licensePlate;
            Date = date;
            //By default brobizz is not used, if someone uses, the property then can later be set to true
            BrobizzUsed = false;
        }
        /// <summary>
        /// Licenseplate property that can also not have over 7 chars. Auto Properties do not support logic so we need to add backing field properties.
        /// </summary>
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

        public bool BrobizzUsed { get; set; }

        /// <summary>
        /// Abstract method, that needs to be implemented on all of the child classes.
        /// </summary>
        /// <returns>Returns a double the price of the ticket for the specific vehicle</returns>
        public abstract double Price();
        /// <summary>
        /// Abstract method, that needs to be implemented on all of the child classes.
        /// </summary>
        /// <returns>Returns a string that says type of vehicle</returns>
        public abstract string VehicleType();
    }
}
