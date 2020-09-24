using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.People
{
    class Teacher : IPerson
    {
        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public int Age { get; set; }

        // sets tenured to false by default
        public bool Tenured { get; set; } = false;

        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
