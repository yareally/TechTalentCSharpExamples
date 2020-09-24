using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Organisms
{
    public class Animal {
        public int Id;
        public string Name;

        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void Announce()
        {
            Console.WriteLine("Hello, I am an animal.");
        }
    }
}
