using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Vehicles
{
    public class Vehicle
    {
        // default # of wheels is 4
        public int Wheels { get; private set; } = 4;

        public Vehicle() {}

        public Vehicle(int wheels) {
            Wheels = wheels;
        }
    }
}
