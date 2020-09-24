using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Vehicles.Interfaces
{
    interface IVehicle
    {
        void ChangeGear(int newGear);

        void Accelerate(int increment);

        void Brake(int decrement);

        int Speed { get; set; }
    }
}
