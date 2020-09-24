using System;
using System.Collections.Generic;
using System.Text;

using CSharpDataTypes.InterfacesExtensibility.Interfaces;

namespace CSharpDataTypes.InterfacesExtensibility
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
