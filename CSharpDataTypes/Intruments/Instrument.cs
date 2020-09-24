using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Intruments
{
    abstract class Instrument
    {
        private string name = "";


        public Instrument(string name)
        {
            this.name = name;
        }

        public abstract void CreateSound();

        public void Play()
        {
            Console.WriteLine($"Playing the {name}");
        }
    }
}
