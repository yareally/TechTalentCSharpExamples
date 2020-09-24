using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.Vehicles.Interfaces;

namespace CSharpDataTypes.Vehicles
{
    class Truck : Vehicle, IVehicle
    {
        public int Speed { get; set; }
        private int gear;

        public void Accelerate(int increment)
        {
            Speed += increment;
        }

        public void Brake(int decrement)
        {
            Speed -= decrement;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"speed: {Speed} gear: {gear}");
        }
    }
}
