using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.Vehicles.Interfaces;

namespace CSharpDataTypes.Vehicles
{
    class RallyCar : IVehicle
    {
        public int Speed { get; set; }
        private int gear;

        /// <inheritdoc />
        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        /// <inheritdoc />
        public void Accelerate(int increment)
        {
            Speed += increment;
        }

        /// <inheritdoc />
        public void Brake(int decrement)
        {
            Speed -= decrement;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"speed: {Speed} gear: {gear}");
        }
    }
}
