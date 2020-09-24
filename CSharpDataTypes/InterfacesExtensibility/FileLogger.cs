using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using CSharpDataTypes.InterfacesExtensibility.Interfaces;

namespace CSharpDataTypes.InterfacesExtensibility
{
    class FileLogger : ILogger
    {
        private readonly string path;
        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using var streamWriter = new StreamWriter(path, true);
            streamWriter.WriteLine($"{messageType}: {message}");
        }
    }
}
