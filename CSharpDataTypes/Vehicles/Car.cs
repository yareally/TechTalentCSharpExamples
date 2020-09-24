using System;

using CSharpDataTypes.Vehicles.Enums;
using CSharpDataTypes.Vehicles.Interfaces;

namespace CSharpDataTypes.Vehicles
{
    public class Car : Vehicle, IVehicle
    {
        private int numberOfDoors;
        private int speed;
        private int currentRPM;
        private int gear;

        public const int MAX_DOORS = 6;
        public const int MIN_DOORS = 1;

        // the "= CarType.FAMILY" sets the object instance for the
        // car's type to FAMILY
        public CarType Type { get; set; } = CarType.FAMILY;


        /// <summary>
        /// Gets or sets the color for the car
        /// </summary>
        public string Color { get; private set; }

        public int NumberOfDoors {
            get { return numberOfDoors;}
            set {
                if (numberOfDoors >= 1 && numberOfDoors <= 6) {
                    numberOfDoors = value;
                }
                else {
                    numberOfDoors = -1;
                }
            }
        }

        public int Speed {
            get { return speed; }
            set {
                speed = value;
            }
        }

        public int CurrentGear { get; private set; } = 1;

        public int CurrentRPM {
            get {
                currentRPM = speed;
                return currentRPM;
            }
        }


        // no-arg constructor
        public Car()
        {
            Color = "White";
            NumberOfDoors = 2;
        }

        // constructor with arguments
        public Car(string color, int numberOfDoors)
        {
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        // constructor with a single argument
        public Car(string color)
        {
            this.Color = color;
            NumberOfDoors = 4;
        }

        // function stop() in javascript
        public void Stop()
        {
            Console.WriteLine("Car stopping");
            Drive();
        }

        public void Start()
        {
            Console.WriteLine("Car starting");
        }

        public void Drive()
        {
            Console.WriteLine("Car driving");
            int currentGear = ShiftUp();
        }

        public override string ToString()
        {
            return $"{Color}, {CurrentGear}, {CurrentRPM}, {Type}";
        }


        public override bool Equals(object obj)
        {
            Car c = (Car)obj;

            return Color.Equals(c.Color) && (numberOfDoors == c.numberOfDoors);
        }

        /// <summary>
        /// Compares the properties of two cars
        /// If the properties are all the same, returns true
        /// If the properties are different, returns false
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>true if properties are the same, false otherwise</returns>
        public static bool Compare(Car x, Car y)
        {
            if (x.Color == y.Color && x.NumberOfDoors == y.NumberOfDoors)
            {
                return true;
            }
            return false;
        }

        private int ShiftUp()
        {
            return ++CurrentGear;
        }

        private int ShiftDown()
        {
            if (CurrentGear == 1) {
                return CurrentGear;
            }
            // otherwise subtract 1 off the gear and return the new gear
            return --CurrentGear;
        }

        public void Accelerate(int increment)
        {
            speed += increment;
        }

        public void Brake(int decrement)
        {
            speed -= decrement;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"speed: {speed} gear: {gear}");
        }
    }
}
