using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.Vehicles.Interfaces;

namespace CSharpDataTypes.Vehicles
{
    public class CrossOver
    {
        /// <inheritdoc />
        public void changeGear(int newGear) { }

        /// <inheritdoc />
        public void accelerate(int increment) { }

        /// <inheritdoc />
        public void brake(int decrement) { }
    }
}
