using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Organisms
{
    public class Bear : Animal
    {
        public float Weight;

        public Bear(int id, string name, float weight) : base(id, name)
        {
            Weight = weight;
        }

        public void Display()
        {
            Console.WriteLine($"{Id}, My name and weight: {Name}, {Weight} Pounds");
        }

        /// <inheritdoc />
        public override void Announce()
        {
            Console.WriteLine("Smarter than the average bear!");
        }
    }
}
